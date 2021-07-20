# ASP.NET Core Web API for AKS - Pokedex

This project was created using the **RobBell.Pokedex.Template** 
`dotnet new aksapi -n Pokedex `  

For more information, visit the project homepage:

https://github.com/robbell/dotnet-aks-api-template/

Internally calls template engine,to find more information on template engine refer below

https://github.com/dotnet/templating/wiki/Available-templates-for-dotnet-new
   

## Project overview

* `chart/` - Helm Charts for deploying to Kubernetes
    * `Chart.yaml`
    * `values.yaml` - includes a reference to the published image
    * `template/`
        * `deployment.yaml`
        * `service.yaml`
* `Controllers/`
    * `v1/`
        * `SampleController.cs` - Sample HTTP endpoint
* `HealthChecks/`
    * `LiveHealthCheck.cs` - used by the Kubernetes liveness probe
    * `ReadyHealthCheck.cs` - used by the Kubernetes readiness probe
* `Properties/`
    * `launchsettings.json`
* `Pokedex.csproj` - ASP.NET Web API project
* `appsettings.json` - includes AppInsights instrumentation key
* `Dockerfile` - Docker containerisation
* `Program.cs`
* `README.md` - this file
* `Startup.cs`
 
 # How to run?

 `
 cd pokedex
 dotnet run
 
 `
 URL to access API  https://localhost:5001/api/v1/Pokedex

# Features included 

* `PokedexController` sample endpoint
* **Docker** containerisation
* **Helm** charts for deploying to Kubernetes
* **OpenAPI** support (Swagger)
* **Health checks** including Kubernetes liveness and readiness probes
* Logging configuration with **AppInsights**

Association
Operation
Versioning
Paging
Caching
Error Handling
Securing
Headers

# Task assigned
1. Return basic Pokemon information
2. Return basic Pokemon information but with a 'fun' transalation of the Pokemon description.