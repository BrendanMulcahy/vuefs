namespace vuefs.Controllers

open System
open System.Linq
open Microsoft.AspNetCore.Mvc

type WeatherForecast public () =
    member val DateFormatted : string = null with get, set

    member val TemperatureC : int = 0 with get, set

    member val Summary : string = null with get, set

    member this.TemperatureF =
        32 + (int)((float this.TemperatureC) / 0.5556)

[<Route("api/[controller]")>]
type SampleDataController () =
    inherit Controller()

    let Summaries = [|"Freezing"; "Bracing"; "Chilly"; "Cool"; "Mild"; "Warm"; "Balmy"; "Hot"; "Sweltering"; "Scorching"|]

    [<HttpGet("[action]")>]
    member __.WeatherForecasts() =
        let rng = Random()
        Enumerable.Range(1, 5).Select(fun index ->
            WeatherForecast(
                DateFormatted = DateTime.Now.AddDays(float index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries.[rng.Next(Summaries.Length)]
        ))
