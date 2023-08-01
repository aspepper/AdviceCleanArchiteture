  <h2 align="center">Acades Patterns</h2>

  <p align="center">
    Template de API com base sólida para o desenvolvimento ágil de diversos sistemas da Acades, fornecendo funcionalidades essenciais para uma construção mais rápida e eficiente.
    <br />
    <a href="https://github.com/aspepper/CleanArchitecture"><strong> Ver Repositório
    »</strong></a>
    <br />
    <br />
  </p>
</p>

<br>

## Mapa da Solução 🗺️

* [Sobre o Template 🔍](#about)
* [Conceitos-Chave 🔑](#keys)
* [Padronizações 🔒](#default)
* [Arquitetura Geral e Fluxo de Desenvolvimento 🏰](#architecture)
* [Nomenclatura de Classes e Pastas 📁](#nomenclatures)
* [Sobre os Projetos na Solução 📂](#projects)
* [Pacotes dos Projetos 📦](#packages)
* [Configuração e Implantação 👩‍💻](#configs)
* [Boas Práticas e Considerações 🧹](#habits)

<br>
<br>

<div id='about'/>

## Sobre o Template 🔍
API de um sistema de listas a fazer que oferece uma ***solução moderna e escalável*** para gerenciar tarefas pessoais. Com ela, os usuários podem criar, atualizar e excluir listas (***CRUD***), além de adicionar e manipular tarefas individuais.

A arquitetura da API incorpora conceitos e como ***CQRS***, ***Event Sourcing***, ***MediatR***, ***SAGA***, ***TDD***, ***DDD*** e ***Clean Code*** garantindo uma estrutura sólida e eficiente.

O objetivo principal é proporcionar aos usuários uma experiência intuitiva e eficaz para gerenciar suas atividades diárias.

<br>
<br>

<div id='keys'/>

## Conceitos-Chave 🔑
A seguir, serão apresentadas as explicações dos conceitos-chave citados acima que fundamentam a API de sistema de listas a fazer:

* ***<ins>CQRS (Command Query Responsibility Segregation):***</ins> <br>
É um padrão arquitetural utilizado na API para separar as operações de leitura (***queries***) das operações de escrita (***commands***). Isso permite uma ***melhor separação de preocupações*** e ***otimização de desempenho*** ao lidar com diferentes tipos de operações.

* ***<ins>Event Sourcing:***</ins> <br>
A API utiliza o conceito de eventos para ***notificar*** e ***reagir a mudanças no estado das entidades***. Os eventos são emitidos sempre que uma ação significativa ocorre, como a ***criação de uma nova lista de tarefas*** ou a ***conclusão de uma tarefa***. Esses eventos podem ser consumidos por outros componentes do sistema para realizar ações adicionais, como envio de notificações ou atualização de outras entidades relacionadas.

* ***<ins>MediatR:***</ins> <br>
É um padrão de design que permite a ***comunicação*** e o ***gerenciamento de comandos/queries e eventos*** entre os diferentes componentes da API. Ele facilita o uso do padrão CQRS, permitindo a ***separação*** e o ***tratamento adequado das solicitações de comandos/queries e eventos***.

* ***<ins>SAGA Orchestration Pattern:***</ins> <br>
É utilizado para ***orquestrar*** e g***erenciar transações complexas*** e ***processos de negócios*** que envolvem várias etapas e componentes. Na API, as SAGAs podem ser ***usadas para lidar com fluxos de trabalho que envolvem várias operações*** relacionadas a tarefas e listas de tarefas, garantindo que essas operações sejam executadas de ***forma consistente*** e ***confiável***.

* ***<ins>DDD (Domain-Driven Design):***</ins> <br>
Abordagem de design de software que visa a ***modelagem do domínio de negócios*** de forma eficiente e coesa. A API segue os princípios do DDD para organizar as entidades, agregados, serviços e eventos em uma estrutura de domínio clara e compreensível, permitindo um ***design flexível*** e ***escalável***.

* ***<ins>Clean Code:***</ins> <br>
A API adota os princípios do Clean Code para promover um ***código legível***, ***conciso*** e de ***fácil manutenção***. Isso inclui a utilização de nomenclatura significativa para classes e métodos, a criação de funções pequenas e bem definidas, a eliminação de duplicação de código e a adoção de boas práticas de programação.

* ***<ins>TDD (Test-Driven Development):***</ins> <br>
Abordagem de desenvolvimento que enfatiza a ***criação de testes unitários*** antes da implementação do código. Na API, são utilizados testes unitários para ***verificar a corretude*** e a ***robustez das funcionalidades implementadas***. Os testes garantem que a API esteja funcionando conforme o esperado, fornecendo ***maior confiabilidade*** e ***facilitando a manutenção do código***.

<br>
<br>

<div id='default'/>

## Padronizações 🔒
A API adota as seguintes padronizações:

* ***<ins>Padronização de documentos:***</ins> <br>
A API utiliza máscaras, tamanhos e expressões regulares para formatar campos de documentos relacionados a um domínio de tipo. Isso garante que os documentos sejam inseridos e exibidos de forma padronizada.

* ***<ins>Padronização de tipagens, data e número:***</ins> <br>
Utiliza o formato ISO/GNT para padronizar as tipagens, datas e números. Além disso, o padrão UTC é utilizado para armazenamento de datas e horas, garantindo consistência e interoperabilidade.

* ***<ins>Template para tela:***</ins> <br>
A API fornece templates para telas que incluem validação de dados, formatação e outras funcionalidades relacionadas à interface do usuário. Isso ajuda a garantir uma experiência consistente e amigável para os usuários da API.

* ***<ins>Template para API:***</ins> <br>
A API utiliza templates padronizados para garantir a segurança, validação de dados e outras funcionalidades essenciais em suas interfaces de programação. Isso facilita o desenvolvimento de novas funcionalidades e garante a consistência das APIs.

* ***<ins>Acesso a banco de dados:***</ins> <br>
É utilizado o EntityFramework para facilitar o acesso e a manipulação dos dados no banco de dados. Isso permite uma abstração eficiente das operações de banco de dados e melhora a produtividade do desenvolvimento.

* ***<ins>Tratamento de log:***</ins> <br>
A API utiliza o NLog para o tratamento de log e exceções. Isso permite registrar informações relevantes e identificar a origem das consultas e operações realizadas na API. 

* ***<ins>Multi-idioma:***</ins> <br>
Suporta os idiomas português, inglês e espanhol, possibilitando a internacionalização da aplicação e atendendo a diferentes públicos.

* ***<ins>LGPD (Lei Geral de Proteção de Dados):***</ins> <br>
A API está em conformidade com a LGPD. Ela implementa mecanismos para garantir a privacidade e a segurança dos dados, como a pesquisa por nome e documento, que pode ser realizada por partícula, garantindo a proteção dos dados pessoais.

<br>
<br>

<div id='architecture'/>

## Arquitetura Geral e Fluxo de Desenvolvimento 🏰
A arquitetura da solução segue uma abordagem modular, dividida em diferentes camadas e componentes que se encaixam para fornecer a funcionalidade completa da API.

* _**Camada 0 - <ins>AcadesArchitecturePattern.Tests**_</ins> 
  * Será desenvolvido e implementado conforme o andamento de todos os projetos da solução.
  * Contém os testes unitários para todas as entidades, comandos, consultas e manipuladores do projeto.

<br>

* _**Camada 1 - <ins>AcadesArchitecturePattern.Shared**_</ins>

  * ***Entities:*** Contém a definição de entidades base (Base) que podem ser estendidas por outras entidades.

  * ***Commands:*** Define os comandos da API, como GenericCommandResult, ICommand e ICommandResult, que são usados para executar operações de criação, atualização e exclusão.

  * ***Queries:*** Define as consultas da API, como GenericQueryResult, IQuery e IQueryResult, que são usadas para recuperar informações dos dados.

  * ***Handlers:*** Define os contratos para manipuladores de comandos (IHandlerCommand) e consultas (IHandlerQuery).

  * ***Events:*** Define eventos base (BaseEvent) que podem ser usados para notificar e reagir a mudanças no sistema.

  * ***Enums:*** Define enumerações, como EnColor, EnStatusTask e EnTaskPriorityLevel, usadas para representar diferentes propriedades e estados.

  * ***Utils:*** Contém a implementação de utilitários, como PasswordEncryption, usado para criptografar senhas.

<br>

* _**Camada 2 - <ins>AcadesArchitecturePattern.Domain**_</ins>

  * ***Entities:*** Define as entidades específicas do domínio, como User, ToDoList e Task, que representam os objetos principais do sistema.

  * ***Commands:*** Define os comandos relacionados a cada entidade, como CreateUserCommand, CreateToDoListCommand, etc.

  * ***Queries:*** Define as consultas relacionadas a cada entidade, como ListUserQuery, ListToDoListQuery, etc.

  * ***Events:*** Define eventos específicos para cada entidade, como UserEvent, ToDoListEvent, etc.

  * ***Interfaces:*** Define as interfaces de serviço (ITaskService, IToDoListService, IUserService) para a manipulação das entidades.

<br>

* _**Camada 3 - <ins>AcadesArchitecturePattern.Infra.Data**_</ins>
 
  * ***Mappings:*** Contém as classes de mapeamento (TaskMapping, ToDoListMapping, UserMapping) para mapear as entidades do domínio no banco de dados.

  * ***Contexts:*** Representa o contexto do banco de dados desejado(AcadesArchitecturePatternSqlServerContext) que permite o acesso aos dados.

  * ***Services:*** Fornecem a implementação dos serviços relacionados a cada entidade, como TaskService, ToDoListService, UserService.

<br>

* _**Camada 4 - <ins>AcadesArchitecturePattern.Application**_</ins> 
  * ***Handlers:*** Implementam os manipuladores (Handlers) que lidam com os comandos e consultas específicos do domínio.

  * ***Security:*** Contém o JwtTokenGenerator, responsável por gerar tokens JWT para autenticação.

  * ***Services:*** Fornece a implementação de serviços específicos, como UserMappingService.

<br>

* _**Camada 5 - <ins>AcadesArchitecturePattern.Api**_</ins> 
  * ***Controllers:*** Contém os controladores (Controllers) que fornecem os pontos de extremidade da API para manipulação das entidades.

<br>
<br>

<div id='nomenclatures'/>

## Nomenclatura de Classes e Pastas 📁
A convenção de nomenclatura segue algumas diretrizes para tornar a estrutura do código mais compreensível e consistente. Aqui estão alguns exemplos de nomenclatura com seus significados:

* _<ins>***Classes:***_</ins> 
  * ***ClassName:*** As classes são nomeadas utilizando o padrão ***PascalCase*** no ***singular***, seguindo a convenção de iniciar cada palavra com letra maiúscula. Além disso, é importante utilizar nomes ***em inglês*** para aderir à convenção correta de nomenclatura.
    * ***Exemplos:*** User, ToDoList, Task, CreateUserCommand, IToDoListService, SearchTaskByIdQuery.

<br>

* _<ins>***Pastas:***_</ins> 
  * ***FolderNames:*** As pastas são nomeadas utilizando o padrão ***PascalCase*** no ***plural***, seguindo a convenção de iniciar cada palavra com letra maiúscula. Além disso, é importante utilizar nomes ***em inglês*** para aderir à convenção correta de nomenclatura.
    * ***Exemplos:*** Entities, Commands, Queries, Controllers, Services, Contexts. <br>

<br>

* _<ins>***Nomenclatura de Classes Específicas:***_</ins> 

  #### ***Commands:***

  * ***[Action][Entity]Command:*** Segue o padrão, no qual, onde está ***[Action] é substituído pela a ação*** que o Command fará e onde está ***[Entity] é substituído pela entidade*** relacionada.
    * ***Exemplos:*** CreateTaskCommand, DeleteUserCommand, UpdateToDoListCommand. <br>

  <br>
  <br>

  #### ***Queries:***

  * ***List[Entity]Query:*** Segue o padrão, no qual, onde está ***[Entity] é substituído pela entidade*** relacionada.
    * ***Exemplos:*** ListTaskQuery, ListUserQuery, ListToDoListQuery. <br>

  <br>

  * ***Search[Entity]By[Parameter]Query:*** Segue o padrão, no qual, onde está ***[Entity] é substituído pela entidade*** relacionada e onde está ***[Parameter] é substituído pelo nome do parâmetro*** da consulta.
    * ***Exemplos:*** SearchTaskByIdQuery, SearchUserByUserNameQuery, SearchUserByEmailQuery. <br>

  <br>
  <br>

  #### ***Handlers:***

  * ***[Action][Entity]Handle:*** Segue o padrão, no qual, onde está ***[Action] é substituído pela a ação*** que o Handler fará e onde está ***[Entity] é substituído pela entidade*** relacionada. Por fim, será adicionado a palavra ***Handle***, ***SEM a letra "r"*** como é escrito Handler.
    * ***Exemplos:*** CreateTaskHandle, DeleteUserHandle, UpdateToDoListHandle. <br>

  <br>

  * ***Search[Entity]By[Parameter]Handle:*** Segue o padrão, no qual, onde está ***[Entity] é substituído pela entidade*** relacionada e onde está ***[Parameter] é substituído pelo nome do parâmetro***. Por fim, será adicionado a palavra ***Handle***, ***SEM a letra "r"*** como é escrito Handler.
    * ***Exemplos:*** SearchTaskByIdHandle, SearchUserByUserNameHandle, SearchUserByEmailHandle. <br>

  <br>
  <br>

  #### ***Interfaces:***

  * ***I[Entity]Service:*** Segue o padrão, no qual, é ***acompanhado da letra "I" no início*** e onde está ***[Entity] é substituído pela entidade***. 
    * ***Exemplos:*** ITaskService, IToDoListService, IUserService. <br>

  <br>
  <br>

  #### ***Contexts:***

  * ***[SolutionName][DatabaseName]Context:*** Segue o padrão, no qual, onde está ***[SolutionName] é substituído pelo nome da solução*** e onde está ***[DatabaseName] é substituído pelo nome do banco de dados que será utilizado***.
    * ***Exemplos:*** AcadesArchitecturePatternSqlServerContext, AcadesArchitecturePatternOracleContext, AcadesArchitecturePatternMySqlContext. <br>

  <br>
  <br>

  #### ***Mappings:***

  * ***[Entity]Mapping:*** Segue o padrão, no qual, onde está ***[Entity] é substituído pela entidade***.
    * ***Exemplos:*** TaskMapping, ToDoListMapping, UserMapping. <br>

  <br>
  <br>

  #### ***Services:***

  * ***[Entity]Service:*** Segue o padrão, no qual, onde está ***[Entity] é substituído pela entidade***. 
    * ***Exemplos:*** TaskService, ToDoListService, UserService. <br>

  <br>
  <br>

  #### ***Events:***

  * ***[Entity]Event:*** Segue o padrão, no qual, onde está ***[Entity] é substituído pela entidade***. 
    * ***Exemplos:*** TaskEvent, ToDoListEvent, UserEvent. <br>

  <br>
  <br>

  #### ***Controllers:***

  * ***[Entities]Controller:*** Segue o padrão, no qual, onde está ***[Entities] é substituído pela entidade no plural***. 
    * ***Exemplos:*** TasksController, ToDoListsController, UsersController. <br>

  <br>
  <br>

  #### ***Tests:***

  * ***[Entity]Test:*** Segue o padrão, no qual, onde está ***[Entity] é substituído pela entidade***. 
    * ***Exemplos:*** TaskTest, ToDoListTest, UserTest. <br>

  <br>

  * ***[CommandName]Test:*** Segue o padrão, no qual, onde está ***[CommandName] é substituído pelo nome inteiro do command*** da entidade relacionada. 
    * ***Exemplos:*** CreateTaskCommandTest, DeleteUserCommandTest, UpdateToDoListCommandTest. <br>

  <br>

    * ***[QueryName]Test:*** Segue o padrão, no qual, onde está ***[QueryName] é substituído pelo nome inteiro da query*** da entidade relacionada. 
      * ***Exemplos:*** ListTaskQueryTest, SearchUserByIdQueryTest, SearchUserByUserNameQueryTest. <br>

  <br>

    * ***[HandleName]Test:*** Segue o padrão, no qual, onde está ***[HandleName] é substituído pelo nome inteiro do handle*** da entidade relacionada. 
      * ***Exemplos:*** CreateTaskHandleTest, ListToDoListHandleTest, UpdateUserHandleTest. <br>

<br>
<br>

<div id='projects'/>

## Sobre os Projetos na Solução 📂
Projetos presentes na solução e uma breve descrição do propósito de cada um e seus tipos:

* _<ins>***AcadesArchitecturePattern (Solução em Branco):***_</ins> 
  * ***Descrição:*** Solução de projeto vazia para desenvolvimento de sistemas escaláveis.
  * ***Propósito:*** Fornecer uma estrutura organizada e modular para o desenvolvimento de aplicativos de software.

<br>

* _<ins>***AcadesArchitecturePattern.Shared (Biblioteca de Classes):***_</ins> 
  * ***Descrição:*** Contém classes e estruturas compartilhadas que são utilizadas em toda a solução.
  * ***Propósito:*** Fornecer funcionalidades comuns e reutilizáveis para outros projetos da solução.

<br>

* _<ins>***AcadesArchitecturePattern.Domain (Biblioteca de Classes):***_</ins> 
  * ***Descrição:*** Contém as entidades de domínio do sistema, como User (usuário), ToDoList (lista de tarefas) e Task (tarefa).
  * ***Propósito:*** Definir as entidades de domínio e suas regras de negócio, encapsulando a lógica do domínio.

<br>

* _<ins>***AcadesArchitecturePattern.Infra.Data (Biblioteca de Classes):***_</ins> 
  * ***Descrição:*** Responsável pelo acesso a dados e persistência, contendo mapeamentos e contextos dos bancos de dados.
  * ***Propósito:*** Implementar a camada de acesso a dados, interagindo com os bancos de dados e realizando operações de persistência.

<br>

* _<ins>***AcadesArchitecturePattern.Application (Biblioteca de Classes):***_</ins> 
  * ***Descrição:*** Implementa os handlers dos commands e queries, bem como outros serviços da aplicação.
  * ***Propósito:*** Gerenciar a lógica de negócio da aplicação, processando commands e consultas, e fornecer serviços específicos.

<br>

* _<ins>***AcadesArchitecturePattern.Api (Projeto de Aplicativo):***_</ins> 
  * ***Descrição:*** Contém os controladores da API RESTful, que recebem as solicitações HTTP e fornecem as respostas correspondentes.
  * ***Propósito:*** Expor endpoints da API para interação com clientes externos, lidando com a comunicação e a lógica de apresentação.

<br>

* _<ins>***AcadesArchitecturePattern.Tests (Projeto de Teste):***_</ins> 
  * ***Descrição:*** Contém testes unitários para as entidades, commands, queries e handlers da aplicação.
  * ***Propósito:*** Verificar a correta implementação das funcionalidades, garantir a qualidade do código e evitar regressões.

<br>
<br>

<div id='packages'/>

## Pacotes dos Projetos 📦
Pacotes presentes nos projetos e uma breve descrição do propósito de cada um:

* _**Projeto - <ins>AcadesArchitecturePattern.Shared**_</ins> 
  * ***BCrypt.Net-Core (versão 1.6.0):*** Biblioteca que fornece suporte para hashing de senhas usando o algoritmo BCrypt. <br>

  <br>

  * ***Flunt (versão 2.0.5):*** Biblioteca que fornece suporte para validação de objetos e notificações de erros. <br>

  <br>

  * ***MediatR (versão 12.0.1):*** Biblioteca que implementa o padrão Mediator para a comunicação entre diferentes componentes de um aplicativo. <br>

<br>
<br>

* _**Projeto - <ins>AcadesArchitecturePattern.Domain**_</ins> 
  * ***Acades.Abstractions (versão 2023.7.3.926-alpha):*** Biblioteca que contém abstrações e interfaces comuns usadas em arquiteturas baseadas em CQRS (Command Query Responsibility Segregation) e Event Sourcing. <br>

  <br>

  * ***Acades.Saga (versão 2023.7.3.957-alpha):*** Biblioteca que fornece suporte para implementação de padrão de projeto Saga em arquiteturas orientadas a eventos. <br>

  <br>

  * ***MediatR (versão 12.0.1):*** Biblioteca que implementa o padrão Mediator para a comunicação entre diferentes componentes de um aplicativo. <br>

  <br>

  * ***MediatR (versão 12.0.1):*** Fornece suporte para a injeção de dependência no ASP.NET Core. <br>

  <br>

  * ***Microsoft.Extensions.DependencyModel (versão 7.0.0):*** Fornece recursos para acessar informações sobre dependências de tempo de execução. <br>

  <br>

  * ***Microsoft.Extensions.Logging (versão 7.0.0):*** Fornece recursos de registro de logs no ASP.NET Core. <br>

  <br>

  * ***Microsoft.Extensions.Logging.Abstractions (versão 7.0.1):*** Contém abstrações para recursos de logging no ASP.NET Core. <br>

  <br>

  * ***Microsoft.Extensions.Logging.Debug (versão 7.0.0):*** Fornece um provedor de log que escreve mensagens no depurador durante o desenvolvimento. <br>

  <br>

  * ***Scrutor (versão 4.2.2):*** Biblioteca que simplifica o registro de serviços com base em convenções usando a injeção de dependência do ASP.NET Core. <br>

<br>
<br>

* _**Projeto - <ins>AcadesArchitecturePattern.Infra.Data**_</ins> 
  * ***Microsoft.EntityFrameworkCore (versão 7.0.5):*** Fornece acesso a dados e recursos de mapeamento objeto-relacional para o Entity Framework Core. <br>

  <br>

  * ***Microsoft.EntityFrameworkCore.Design (versão 7.0.5):*** Fornece suporte para a geração de código e ferramentas de design do Entity Framework Core. <br>

  <br>

  * ***Microsoft.EntityFrameworkCore.Relational (versão 7.0.5):*** Fornece suporte para recursos relacionais adicionais no Entity Framework Core. <br>

  <br>

  * ***Microsoft.EntityFrameworkCore.SqlServer (versão 7.0.5):*** Fornece suporte específico para o uso do SQL Server no Entity Framework Core. <br>

  <br>

  * ***Microsoft.EntityFrameworkCore.Tools (versão 7.0.5):*** Fornece ferramentas adicionais para o Entity Framework Core, como migrações de banco de dados. <br>

<br>
<br>

* _**Projeto - <ins>AcadesArchitecturePattern.Application**_</ins> 
  * ***FluentValidation.DependencyInjectionExtensions (versão 11.5.2):*** Fornece suporte para a integração do FluentValidation com a injeção de dependência do ASP.NET Core. <br>

  <br>

  * ***MediatR (versão 12.0.1):*** Biblioteca que implementa o padrão Mediator para a comunicação entre diferentes componentes de um aplicativo. <br>

  <br>

  * ***MediatR.Extensions.Microsoft.DependencyInjectionFixed (versão 5.1.2):*** Fornece suporte para a integração do MediatR com a injeção de dependência do ASP.NET Core. <br>

  <br>

  * ***Microsoft.AspNetCore.Authentication.JwtBearer (versão 7.0.5):*** Fornece suporte para autenticação baseada em tokens JWT (JSON Web Token) no ASP.NET Core. <br>

<br>
<br>

* _**Projeto - <ins>AcadesArchitecturePattern.Api**_</ins> 
  * ***Microsoft.AspNetCore.Mvc.NewtonsoftJson (versão 6.0.19):*** Fornece suporte para serialização e desserialização personalizada usando a biblioteca Newtonsoft.Json no ASP.NET Core MVC. <br>

  <br>

  * ***Microsoft.EntityFrameworkCore (versão 7.0.5):*** Fornece acesso a dados e recursos de mapeamento objeto-relacional para o Entity Framework Core. <br>

  <br>

  * ***Microsoft.EntityFrameworkCore.Design (versão 7.0.5):*** Fornece suporte para a geração de código e ferramentas de design do Entity Framework Core. <br>

  <br>

  * ***Microsoft.EntityFrameworkCore.Relational (versão 7.0.5):*** Fornece suporte para recursos relacionais adicionais no Entity Framework Core. <br>

  <br>

  * ***Microsoft.EntityFrameworkCore.SqlServer (versão 7.0.5):*** Fornece suporte específico para o uso do SQL Server no Entity Framework Core. <br>

  <br>

  * ***Microsoft.EntityFrameworkCore.Tools (versão 7.0.5):*** Fornece ferramentas adicionais para o Entity Framework Core, como migrações de banco de dados. <br>

  <br>

  * ***Newtonsoft.Json (versão 13.0.3):*** Uma popular biblioteca de serialização e desserialização JSON. <br>

  <br>

  * ***Swashbuckle.AspNetCore (versão 6.5.0):*** Fornece suporte para geração de documentação interativa da API usando o Swagger/OpenAPI no ASP.NET Core. <br>

<br>
<br>

* _**Projeto - <ins>AcadesArchitecturePattern.Tests**_</ins> 
  * ***FluentAssertions (versão 6.11.0):*** Biblioteca que fornece uma API fluente para escrever asserções em testes unitários. <br>

  <br>

  * ***Microsoft.NET.Test.Sdk (versão 17.5.0):*** Fornece suporte para a execução de testes .NET Core. <br>

  <br>

  * ***Moq (versão 4.18.4):*** Biblioteca que permite a criação de objetos simulados (mocks) para testes unitários. <br>

  <br>

  * ***xUnit (versão 2.4.2):*** Framework de testes unitários para .NET. <br>

<br>
<br>

<div id='configs'/>

## Configuração e Implantação 👩‍💻
Para configurar e implantar a API em diferentes ambientes, como desenvolvimento, teste e produção, você pode seguir as seguintes instruções:

* _<ins>***Configuração Geral:***_</ins> 
  * ***Infraestrutura:*** Windows 2016. <br>

  * ***Bancos de dados:*** SQL Server 2019, Oracle 19G, MySQL 8.0 ou 5.7. <br>

  * ***Versão do SDK e Entity Framework:*** Verifique se você tem as versões corretas do SDK do .NET 7 e do Entity Framework Core 7 instaladas em sua máquina de desenvolvimento. Haverá migração para a versão 8 em novembro de 2023, com limite até maio de 2024. <br>

  * ***Armazenamento de binários na nuvem:*** S3 da Amazon ou Storage Azure para SaaS e OnPremise. <br>

  * ***Repositório de fontes:*** Azure DevOps + Git. <br>

  * ***Adição de serviços:*** As linhas de código relacionadas à adição de serviços (***builder.Services.AddControllers***, ***builder.Services.AddSwaggerGen***) são parte da configuração geral. Elas configuram os serviços necessários para o funcionamento da aplicação, como ***controle de rotas***, ***serialização JSON***, ***documentação do Swagger***, entre outras. <br>
    * Adicionando serviços ao contêiner:
    
      ```
      builder.Services.AddControllers()
      .AddNewtonsoftJson(options =>
      {
          options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
          options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
      });
      ```

    * Conectando ao banco de dados:
    
      ```
      builder.Services.AddDbContext<AcadesArchitecturePatternSqlServerContext>(x =>
      {
          x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
      });
      ```

    * Injeções de dependência:
    
      ```
      #region Users
        builder.Services.AddTransient<IUserService, UserService>();

        // Comandos:
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateUserHandle).Assembly));
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(DeleteUserHandle).Assembly));

        // Consultas:
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(ListUserHandle).Assembly));
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(SearchUserByIdHandle).Assembly));
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(SearchUserByEmailHandle).Assembly));
      #endregion
      ```

  * ***Adição de autorização JWT:*** As linhas de código relacionadas à autenticação JWT (***builder.Services.AddAuthentication*** e ***builder.Services.AddJwtBearer***) também fazem parte da configuração geral. Elas configuram a ***autenticação JWT***, definindo os parâmetros de ***validação do token JWT***. <br>

    * Adicionando autenticação/validação JWT:
    
      ```
      builder.Services.AddAuthentication(options =>
      {
          // Autenticação padrão
          options.DefaultAuthenticateScheme = "JwtBearer";
          options.DefaultChallengeScheme = "JwtBearer";
      })
      .AddJwtBearer("JwtBearer", options =>
      {
          options.TokenValidationParameters = new TokenValidationParameters
          {
              // Parâmetros de validação
              ValidateIssuer = true,
              ValidateAudience = true,
              ValidateLifetime = true,
              IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("AcadesArchitecturePattern-authentication-key")),
              ClockSkew = TimeSpan.FromMinutes(30),
              ValidIssuer = "AcadesArchitecturePattern",
              ValidAudience = "AcadesArchitecturePattern"
          };
      });
      ```

<br>
<br>

* _<ins>***Ambiente de Desenvolvimento:***_</ins> 
  * Certifique-se de ter um servidor de banco de dados disponível para uso no ambiente de desenvolvimento. Isso pode ser o SQL Server Express ou o LocalDB, dependendo da sua escolha. <br>

  * Abra o arquivo ***appsettings.json*** ou o ***appsettings.Development.json*** no projeto ***AcadesArchitecturePattern.Api***. <br>

  * Verifique a string de conexão denominada "***DefaultConnection***". Certifique-se de que esteja correta para o ambiente de desenvolvimento. <br>

    * Exemplo de conexão na ***appsettings.json*** ou na ***appsettings.Development.json*** para o ***SQL Server Express***: <br>
      ```
      {
        "Logging": {
          "LogLevel": {
            "Default": "Information",
            "Microsoft.EntityFrameworkCore.Database.Command": "Warning"
          }
        },
        "AllowedHosts": "*",
        "ConnectionStrings": {
          // SQL Server Connection
          "DefaultConnection": "Server=.\\SQLEXPRESS; Database=AcadesArchitecturePatternDb; Integrated Security=True; TrustServerCertificate=True"
        }
      }
      ```

    * Exemplo de conexão na ***appsettings.json*** ou na ***appsettings.Development.json*** para o ***LocalDB***: <br>
      ```
      {
        "Logging": {
          "LogLevel": {
            "Default": "Information",
            "Microsoft.EntityFrameworkCore.Database.Command": "Warning"
          }
        },
        "AllowedHosts": "*",
        "ConnectionStrings": {
          // SQL Server Connection
          "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AcadesArchitecturePatternDb;Trusted_Connection=True;MultipleActiveResultSets=true"
        }
      }
      ```

  * Certifique-se de que as demais configurações no arquivo ***appsettings.json*** ou ***appsettings.Development.json*** estejam ajustadas para o ambiente de desenvolvimento. <br>

  * ***Adição do Swagger:*** As linhas de código relacionadas ao Swagger (***builder.Services.AddSwaggerGen***, ***app.UseSwagger***, ***app.UseSwaggerUI***) são comumente usadas no ambiente de desenvolvimento para documentar e testar a API. Elas fornecem uma interface interativa para explorar e testar os endpoints da API. <br>  
    * Adicionando autorização no Swagger:

      ```
      builder.Services.AddSwaggerGen(c =>
      {
          c.SwaggerDoc("v1", new OpenApiInfo { Title = "AcadesArchitecturePattern.Api", Version = "v1" });

          // Definindo definição de segurança do Swagger para autenticação Bearer
          c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
          {
              Name = "Authorization",
              Type = SecuritySchemeType.ApiKey,
              Scheme = "Bearer",
              BearerFormat = "JWT",
              In = ParameterLocation.Header,
              Description = "JWT Authorization header using the Bearer scheme.\r\n\r\n Enter 'Bearer'[space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
          });

          // Requerendo segurança Bearer para as operações do Swagger
          c.AddSecurityRequirement(new OpenApiSecurityRequirement
          {
              {
                  new OpenApiSecurityScheme
                  {
                      Reference = new OpenApiReference
                      {
                          Type = ReferenceType.SecurityScheme,
                          Id = "Bearer"
                      }
                  },
                  new string[] {}
              }
          });
      });
      ```

    * Configurando o pipeline de solicitação HTTP:
    
      ```
      app.UseSwagger();
      app.UseSwaggerUI();
      ```

  <br>

  * ***Adição do CORS:*** A linha de código relacionada ao CORS (***builder.Services.AddCors***) também é comumente usada no ambiente de desenvolvimento para permitir solicitações HTTP de origens diferentes. Isso é útil durante o desenvolvimento e teste da API em um ambiente local. <br>

    * Adicionando suporte CORS:
    
      ```
      builder.Services.AddCors();
      ```

<br>
<br>

* _<ins>***Iniciando a Migração e Criando o Banco de Dados pelo Code First:***_</ins> 
  * Certifique-se de ter um servidor de banco de dados adequado configurado e disponível no ambiente de produção, como um servidor SQL dedicado ou um serviço de banco de dados gerenciado.

  <br>

  * Abra o ***Console do Gerenciador de Pacotes*** no Visual Studio:
    * No ***menu superior***, clique em "***Ferramentas***" > "***Gerenciador de Pacotes NuGet***" > "***Console do Gerenciador de Pacotes***".

  <br>

  * No Console do ***Gerenciador de Pacotes***, selecione o projeto ***AcadesArchitecturePattern.Infra.Data*** no menu suspenso "***Projeto Padrão***". Certifique-se de que o projeto esteja selecionado corretamente antes de executar os comandos.

  <br>

  * Execute o seguinte comando para adicionar uma nova migração: 
  
    ```
    add-migration [NomeDaMigration] -context [NomeDoContext]
    ```

    * Exemplo para adicionar uma nova migração:
    
        ```
        add-migration Migration1 -context AcadesArchitecturePatternSqlServerContext
        ```

  <br>

  * Após a criação da migração, execute o seguinte comando para aplicar as migrações e criar o banco de dados: 

    ```
    update-database
    ```

    * Esse comando executará todas as migrações pendentes no banco de dados especificado na string de conexão. Se o banco de dados não existir, ele será criado.

  <br>

  * Após a conclusão bem-sucedida da execução do comando update-database, o banco de dados estará criado e pronto para ser usado pela API. 

<br>
<br>

* _<ins>***Ambiente de Produção:***_</ins> 
  * Certifique-se de que as configurações de conexão com o banco de dados no arquivo ***appsettings.json*** ou ***appsettings.Development.json*** estejam corretas para o ambiente em que você deseja criar o banco de dados. <br>

  * Verifique se todas as configurações relacionadas à segurança, como chaves de API, autenticação e autorização, estão adequadamente configuradas para o ambiente de produção. <br>

  * ***Adição de redirecionamento HTTPS:*** As linhas de código relacionadas ao redirecionamento HTTPS (***builder.Services.AddHttpsRedirection*** e ***app.UseHttpsRedirection***) na Program.cs fazem parte do ambiente de produção. Elas garantem que as solicitações sejam redirecionadas para o protocolo HTTPS para maior segurança. <br>
    * Código da ***Program.cs*** no projeto ***AcadesArchitecturePattern.Api***:
    
        ```
        builder.Services.AddHttpsRedirection(options =>
        {
            options.RedirectStatusCode = (int)HttpStatusCode.TemporaryRedirect;
            options.HttpsPort = 5001;
        });
        ```

  <br>

  * ***Utilização de injeção de dependência:*** O controller faz uso da injeção de dependência para obter uma instância do IMediator, permitindo a utilização do padrão Mediator para tratar comandos e consultas. <br>

    * Exemplo de injeção de dependência no controller:
    
        ```
        private readonly IMediator _mediator;

        public TasksController(IMediator mediator)
        {
            _mediator = mediator;
        }
        ```

  <br>

  * ***Separação de comandos e consultas:*** Os métodos do controller estão organizados em ***duas seções distintas***, uma para ***commands*** e outra para ***queries***. Isso facilita a manutenção e compreensão do código, separando as operações de escrita (commands) das operações de leitura (queries). <br>
    
  <br>

  * ***Tratamento de erros:*** Cada método do controller faz o tratamento adequado dos erros e retorna uma resposta apropriada. Caso ocorra um erro durante o processamento de um command ou query, uma resposta de erro é retornada com uma mensagem descritiva. <br>

  <br>

  * ***Utilização de modelos de dados:*** Alguns métodos do controller recebem dados por meio do corpo da requisição (por exemplo, o ***método Add*** recebe um objeto ***CreateTaskCommand***). Esses objetos são ***utilizados para modelar os dados de entrada de forma estruturada*** e ***facilitar a validação dos mesmos***. <br>

    * Exemplo do método Add:
    
        ```
        // Register a new task
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateTaskCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Success ? Ok(result.Message) : BadRequest(result.Message);
        }
        ```

  <br>

  * ***Uso de respostas HTTP adequadas:*** Os métodos do controller retornam respostas HTTP apropriadas para indicar o resultado da operação. Por exemplo, o método Add retorna um ***código 200 (OK)*** se a operação for bem-sucedida, ou um ***código 400 (Bad Request)*** caso ocorra algum erro. <br>

    * Exemplo do ***método Add***:
    
        ```
        return result.Success ? Ok(result.Message) : BadRequest(result.Message);
        ```

<br>
<br>

<div id='habits'/>

## Boas Práticas e Considerações 🧹
Algumas boas práticas recomendadas para o desenvolvimento e manutenção da sua API:

* ***Log de atividade:*** Todas as telas de parametrização devem registrar as modificações antes e depois. <br>

<br>

* ***Controle de acesso:*** Será utilizado as regras existentes no Corporativo. <br>

<br>

* ***Software para monitoramento:*** Será utilizado o software Prometheus. <br>

<br>

* ***Ferramenta de validação de código:*** Utilização do SonarQube e Zaproxy. <br>

<br>

* ***Processos batch (serviços escaláveis de forma horizontal):*** Utilização do Rabbit MQ e Kubernetes. <br>

<br>

* ***Tipo de integração (API; TXT; VIEWS):*** API como principal e Rabbit MQ como secundária. <br>

<br>

* ***Exportação dos dados:*** Inicialmente via API, salvo em caso o cliente tenha necessidade de consumir em outro formato. <br>

<br>

* ***Conceito de multi-empresa:*** Segregação física. <br>

<br>

* ***Separação de responsabilidades:*** Utilize uma arquitetura em camadas para separar as responsabilidades da API em componentes distintos. Isso facilita a manutenção e a evolução do código, tornando-o mais modular e reutilizável. <br>

<br>

* ***Utilização de padrões de projeto:*** Aplique padrões de projeto como ***Injeção de Dependência***, ***Singleton***, ***Factory***, entre outros, para promover a ***coesão e a flexibilidade*** do código. Isso facilita a ***substituição de componentes***, torna o ***código mais testável*** e ***reduz o acoplamento entre os módulos da API***. <br>

<br>

* ***Validação de dados de entrada:*** Realize a validação dos dados recebidos pela API para ***garantir a consistência*** e a ***integridade dos mesmos***. Utilize mecanismos de validação, como atributos de validação ou bibliotecas específicas, para garantir que os dados estejam corretos antes de serem processados pela API. <br>

<br>

* ***Tratamento adequado de erros:*** Implemente um mecanismo consistente de tratamento de erros na API. Utilize ***códigos de status HTTP apropriados*** para indicar falhas na operação da API. Forneça ***mensagens de erro descritivas e úteis*** para facilitar a depuração e o suporte aos usuários da API. <br>

<br>

* ***Segurança da API:*** Implemente mecanismos de autenticação e autorização para proteger a API contra acesso não autorizado. Utilize protocolos como ***JWT (JSON Web Tokens) para autenticar*** e ***autorizar solicitações*** à API. Considere também a aplicação de técnicas de criptografia para proteger dados sensíveis. <br>

<br>

* ***Documentação clara e abrangente:*** Documente adequadamente a API, fornecendo ***descrições claras de endpoints***, ***parâmetros***, ***códigos de status*** e ***formatos de resposta***. Utilize ferramentas como o ***Swagger*** para gerar automaticamente a documentação da API a partir de anotações no código. <br>

<br>

* ***Testes automatizados:*** Implemente testes automatizados para verificar a funcionalidade e a integridade da API. Utilize frameworks de teste, como ***xUnit***, para criar ***testes unitários***, ***de integração*** e de ***carga***. Isso ajuda a garantir que a API funcione corretamente e detecte possíveis regressões após alterações no código. <br>

<br>

* ***Monitoramento e registro de logs:*** Implante um ***sistema de monitoramento para acompanhar o desempenho*** e a ***disponibilidade da API em tempo real***. Registre ***logs de eventos importantes***, como erros, exceções e operações críticas, para facilitar a análise e o diagnóstico de problemas. <br>

<br>

* ***Escalabilidade:*** Projete a API levando em consideração a escalabilidade. Utilize ***técnicas como balanceamento de carga***, ***dimensionamento horizontal*** e ***uso de serviços em nuvem*** para garantir que a API possa lidar com um grande número de solicitações e crescer conforme a demanda. <br>
