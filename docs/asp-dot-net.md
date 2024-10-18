# ASP .Net

```sh
# Create project
dotnet new webapi -o myapi
```

Les éléments suivants sont créés :

- Program.cs: point d'entrée de l'application qui définit déjà un API Rest et un endoint get.
- api01.csproj: fichier de configuration du projet.
- api01.http: fichier de test de l'API avec l'extension VSCode *Rest Client*.
- Properties, appsettings.Development.json et appsettings.json: permettent de configurer l'application et le serveur

## Prérequis

- Faire confiance au certificat SSL local (pour le dev) `dotnet dev-certs https --trust`

## Création d'une API minimals (un seul fichier)

- Créer un Projet d'API "minimal API" `dotnet new web -o HelloApi`
- Lancer le serveur `dotnet run`, ou en mode hot reload `dotnet watch run`

## Ressources

- [Tutoriel officiel](https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?tabs=visual-studio-code)
