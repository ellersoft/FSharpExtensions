module FSharpExtensions.Input.Read
open System

let rec raw convert validate prompt =
    printf "%s" prompt
    let input = () |> Console.ReadLine
    if input |> validate then
        input |> convert
    else
        printfn "Invalid, please try again."
        raw convert validate prompt
let sbyte = raw SByte.Parse (SByte.TryParse >> function | true, f when f > 0y -> true | _ -> false)
let int16 = raw Int16.Parse (Int16.TryParse >> function | true, f when f > 0s -> true | _ -> false)
let int = raw Int32.Parse (Int32.TryParse >> function | true, f when f > 0 -> true | _ -> false)
let int64 = raw Int64.Parse (Int64.TryParse >> function | true, f when f > 0L -> true | _ -> false)
let float32 = raw Single.Parse (Single.TryParse >> function | true, f when f >= 0.f && f <= 1.f -> true | _ -> false)
let float = raw Double.Parse (Double.TryParse >> function | true, f when f >= 0. && f <= 1. -> true | _ -> false)
