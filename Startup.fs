namespace vuefs

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection

type Startup private () =
    new (configuration: IConfiguration) as this =
        Startup() then
        this.Configuration <- configuration

    member __.ConfigureServices(services: IServiceCollection) =
        services.AddMvc() |> ignore

    member __.Configure(app: IApplicationBuilder, env: IHostingEnvironment) =

        if (env.IsDevelopment()) then
            app.UseDeveloperExceptionPage() |> ignore

        app.UseStaticFiles() |> ignore

        app.UseMvc(fun routes ->
            routes.MapRoute(
                name = "default",
                template = "{controller=Home}/{action=Index}/{id?}") |> ignore
            ) |> ignore

    member val Configuration : IConfiguration = null with get, set
