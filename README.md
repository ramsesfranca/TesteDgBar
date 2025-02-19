# Bar do DG - Ramsés França

# Descrição da solução
Foram desenvolvidas 1 solutions (.sln) e dois projetos (MinhaAplicacao_API - projeto da API) e (MinhaAplicacao_Cliente - projeto cliente/front-end) para demonstrar o devido isolamento entre a API e o front-end.

# Projeto MinhaAplicacao_API (API)
Foi desenvolvida utilizando ASP.NET Core Web API 3.1 e EF Core com Code-first + Migrations. Para persitência dos dados foi utilizado SQL Server 2017.

Dentre as biliotecas utilizadas estão:

- AutoMapper
- FluentValidation
- Swagger

# Projeto MinhaAplicacao_Cliente (Cliente/front-end)
Foi desenvolvida utilizando ASP.NET MVC Core 3.1

# Instruções de execução

Todas as dependências dos projetos foram utilizadas com base em pacotes NuGet, sendo necessário apenas o build assim que as solutions sejam abertas.

Foi criando um script para criação do banco (MinhaAplicacao-API\sql\Script_Criacao_Banco.sql)

Como foi utilizado Code-first com Migrations, para geração da base de dados basta executar o comando Update-Database na CLI do Visual Studio, apontando para o projeto que contém o MinhaAplicacaoDbContext (MinhaAplicacao.Infraestrutura). O programa se encarregará de ler as Migrations e criar as tabelas na base de dados. A connection string aponta para a base MinhaAplicacao numa instância local do SQL Server.

Para rodar os projetos (MinhaAplicacao_API e MinhaAplicacao_Cliente) fiz a seguinte configuração (Iniciando vários projetos de uma vez no Visual Studio), que pode ser visto nesse tutorial: 

https://docs.microsoft.com/pt-br/visualstudio/ide/how-to-set-multiple-startup-projects?view=vs-2019
https://improveandrepeat.com/2019/01/starting-multiple-projects-at-once-in-visual-studio/
https://stackoverflow.com/questions/3850019/running-two-projects-at-once-in-visual-studio


# Documentação da API

Toda a documentação encontra-se na URL: (OBS: API tem que estar em execução)

https://localhost:44398/swagger/index.html

# Pontos de melhoria

Pretendia-se abordar ainda alguns pontos na implementação, mas por questões de tempo optei por focar no funcionamento principal da solução.
Seguem alguns itens de melhoria:

- O acesso à aplicação só poderá ser realizado por um usuário pré-existente via autenticação **basic**.
- Exibir notificações das validações tanto de tela (DataAnnotations) como as de negócio. 
- Implementar teste de integração da API em .NET e garantir pelo menos 80% de cobertura de código.
- Código da Promoções
