module FSharpExtensions.Applications.Path
open System.IO

let combine (vs : string array) = Path.Combine(vs)
let combine2 v1 v2 = [|v1; v2|] |> combine
let combine3 v1 v2 v3 = [|v1; v2; v3|] |> combine
