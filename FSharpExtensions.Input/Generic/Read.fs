module FSharpExtensions.Input.Generic.Read
open System

let rec raw (inputSource : unit -> string) convert validate prompt =
    printf "%s" prompt
    let input = () |> inputSource
    if input |> validate then
        input |> convert
    else
        printfn "Invalid, please try again."
        raw inputSource convert validate prompt
let sbyte (inputSource : unit -> string) =
    raw inputSource SByte.Parse (SByte.TryParse >> function | true, f when f > 0y -> true | _ -> false)
    
let int16 (inputSource : unit -> string) =
    raw inputSource Int16.Parse (Int16.TryParse >> function | true, f when f > 0s -> true | _ -> false)
    
let int (inputSource : unit -> string) =
    raw inputSource Int32.Parse (Int32.TryParse >> function | true, f when f > 0 -> true | _ -> false)
    
let int64 (inputSource : unit -> string) =
    raw inputSource Int64.Parse (Int64.TryParse >> function | true, f when f > 0L -> true | _ -> false)
    
let float32 (inputSource : unit -> string) =
    raw inputSource Single.Parse (Single.TryParse >> function | true, f when f >= 0.f && f <= 1.f -> true | _ -> false)
    
let float (inputSource : unit -> string) =
    raw inputSource Double.Parse (Double.TryParse >> function | true, f when f >= 0. && f <= 1. -> true | _ -> false)
