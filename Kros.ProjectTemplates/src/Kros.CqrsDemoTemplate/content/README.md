# CQRS ToDo demo template

## About
`Kros.Templates.CqrsProjectDemo` is a template to create a demo project according to the CQRS pattern.
Create **ToDo** sample demo ASP.NET Core WebApi application with our recommended directory structure, packages, configuration and basic logic.
More info about the project structure and CQRS can be read in [demo example]([https://link](https://github.com/Kros-sk/Kros.AspNetCore.BestPractices/blob/master/README.md)).

## Quick start

1. Instal `Kros.Templates.CqrsProjectDemo` dotnet template from `nuget.org`.
   `dotnet new -i Kros.Templates.CqrsProjectDemo`
2. Create directory and create your CQRS project.
   `dotnet new kros-cqrs-demo`
   dotnet-cli by this template create runnable project.
4. Change connection string in `appsettings.local.json` to your `SQL Server`.

```
 "ConnectionString": {
    "ProviderName": "System.Data.SqlClient",
    "ConnectionString": "Server={serverName};Initial Catalog={databaseName};Integrated Security=True;"
  },

  "KormMigrations": {
    "ConnectionString": {
      "ProviderName": "System.Data.SqlClient",
      "ConnectionString": "Server={serverName};Initial Catalog={databaseName};Integrated Security=True;"
    },
    "AutoMigrate": "True"
  }
```

5. Run and enjoy.