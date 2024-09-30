# BibliotecaCsharpMvc

<p>Sistema para gerenciamento do estoque de livros de uma biblioteca, em .NET MVC.</p>

## Ferramentas utilizadas

- .NET 8
- Bootstrap 5
- Microsoft Entity Framework Core
- Pomelo Entity Framework MySQL

## Preparação do ambiente
Para rodar o projeto, utlize a IDE que você mais se identifique **(no meu caso, utilizo o Visual Studio for Mac)**, em seguida, altere o arquivo **appsettings.json** para que o projeto se adeque ao seu servidor de **banco de dados**:

**Exemplo do arquivo appsettings.json**:

````java
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "Connection": "Server=127.0.0.1;Port=3306;Database=books;User=root;Password=Dev2020;"
  },
  "AllowedHosts": "*"
}
````

Em seguida, basta criar um banco de dados no MySql com o comando `Create schema {nomeDoBancoDeDados}`

## Execução de testes unitários

Em desenvolvimento.

## Executando o projeto

Para executar em um banco de dados recém criado, certifique-se de apagar (se houver) o conteúdo do diretório `Migrations` e siga com estes comandos:

No Windows:

`add-migration CreatingDatabase`
`update-database`

No Mac:

`dotnet tool install --global dotnet-ef`
`dotnet ef --version`
`dotnet ef migrations add CreatingDatabase`
`dotnet ef database update`

## Links úteis.

- [Excelente tutorial para criação de um sistema com ASP NET MVC](https://www.youtube.com/watch?v=w75Ok7ZhVaU&list=PL8l5r7-11AADIYThFwVOoM3L_m0Dfuiga)