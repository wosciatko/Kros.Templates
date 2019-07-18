# CQRS template

## About
`Kros.Templates.CqrsProject` is a template to create a project according to the CQRS pattern.
Create ASP.NET Core WebApi application with our recommended directory structure, packages, configuration.
It also creates basic commands, queries, a repository for entity that you can name using the `--entityName` and `--entityNamePlural` switches. More info about the project structure and CQRS can be read in [demo example](https://github.com/Kros-sk/Kros.AspNetCore.BestPractices/blob/master/README.md).

## Quick start

1. Instal `Kros.Templates.CqrsProject` dotnet template from `nuget.org`.
   `dotnet new -i Kros.Templates.CqrsProject`
2. Create directory and create your CQRS project.
   `dotnet new kros-cqrs --entityName Person --entityNamePlural People`
   dotnet-cli by this template create runnable project.
3. Change connection string in `appsettings.local.json` to your `SQL Server`.

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
4. Add settings to `appsettings.local.json` for your `Identity Server`.

```
 "IdentityServerHandlers": [
     {
         "AuthenticationScheme": "",
         "ApiName": "",
         "AuthorityUrl": "",
         "Proxy": {
             "Address": ""
         },
         "RequireHttpsMetadata": true
     }
 ]
```

5. Run and enjoy.

## Template options

- `-e` `--entityName` - Main entity name. Template create commands, query, entity, repository, controller, ... for this entity.
- `-en` `--entityNamePlural` - Plural for entity name.
