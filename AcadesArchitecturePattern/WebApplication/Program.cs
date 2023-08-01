using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using System.Globalization;
using WebApplication;
using WebApplication.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Blazored.LocalStorage;

// Inicializa��es B�sicos do Blazor
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Adi��o de Features Elementares
builder.Services.AddLocalization(options => options.ResourcesPath = "Localization");
builder.Services.AddBlazoredLocalStorage();

// Inje��o dos Servi�os Padr�es do Template
builder.Services.AddScoped<IConfigurationService, ConfigurationService>();
builder.Services.AddScoped<IAuthenticateService, AuthenticateService>();


// Configura��o do JWT para aplicar o Authentication e Authorization no front
builder.Services.AddHttpClient("WebAPI",
        client => client.BaseAddress = new Uri("https://www.example.com/base"))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
    .CreateClient("WebAPI"));



// Cria��o de Todos os Objetos
var host = builder.Build();

// Implementa��o da Estrutura para Multi Idiomas
var jsInterop = host.Services.GetRequiredService<IJSRuntime>();
var result = await jsInterop.InvokeAsync<string>("AcadesComplianceCurrentCulture.get");
CultureInfo culture;
if (result != null)
{
    culture = new CultureInfo(result);
}
else
{
    culture = new CultureInfo("pt-BR");
    await jsInterop.InvokeVoidAsync("AcadesComplianceCurrentCulture.set", "pt-BR");
}
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

// Carga das Configura��es 
host.Services.GetRequiredService<IConfigurationService>()?.Get();

// Execu��o da Aplica��o
await host.RunAsync();

/***************************************************************************************
  -------------------------------     Documents     -----------------------------------
    https://www.puresourcecode.com/dotnet/blazor/svg-icons-and-flags-for-blazor/
    https://www.matblazor.com/
***************************************************************************************/
