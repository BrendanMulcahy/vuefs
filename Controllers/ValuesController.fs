namespace vuefs.Controllers

open Microsoft.AspNetCore.Mvc

[<Route("api/[controller]")>]
type ValuesController () =
    inherit Controller()

    [<HttpGet>]
    member __.Get() =
        [|"value1"; "value2"|]

    [<HttpGet("{id}")>]
    member __.Get(id:int) =
        "value"

    [<HttpPost>]
    member __.Post([<FromBody>]value:string) =
        ()

    [<HttpPut("{id}")>]
    member __.Put(id:int, [<FromBody>]value:string ) =
        ()

    [<HttpDelete("{id}")>]
    member __.Delete(id:int) =
        ()
