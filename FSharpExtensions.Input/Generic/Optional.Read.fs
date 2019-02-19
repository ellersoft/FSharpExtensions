module FSharpExtensions.Input.Generic.Optional.Read
open System
open FSharpExtensions.Input.Generic

let sbyte (inputSource : unit -> string) minimum =
    Read.raw
        inputSource
        (function | "" -> None | s -> s |> SByte.Parse |> Some)
        (function
         | "" -> true
         | s -> s |> SByte.TryParse |> function | true, n -> (match minimum with | Some m -> n >= m | _ -> true) | _ -> false)
let int16 (inputSource : unit -> string) minimum =
    Read.raw
        inputSource
        (function | "" -> None | s -> s |> Int16.Parse |> Some)
        (function
         | "" -> true
         | s -> s |> Int16.TryParse |> function | true, n -> (match minimum with | Some m -> n >= m | _ -> true) | _ -> false)
let int (inputSource : unit -> string) minimum =
    Read.raw
        inputSource
        (function | "" -> None | s -> s |> Int32.Parse |> Some)
        (function
         | "" -> true
         | s -> s |> Int32.TryParse |> function | true, n -> (match minimum with | Some m -> n >= m | _ -> true) | _ -> false)
let int64 (inputSource : unit -> string) minimum =
    Read.raw
        inputSource
        (function | "" -> None | s -> s |> Int64.Parse |> Some)
        (function
         | "" -> true
         | s -> s |> Int64.TryParse |> function | true, n -> (match minimum with | Some m -> n >= m | _ -> true) | _ -> false)
let float32 (inputSource : unit -> string) minimum = 
    Read.raw
        inputSource
        (function | "" -> None | s -> s |> Single.Parse |> Some)
        (function
         | "" -> true
         | s -> s |> Single.TryParse |> function | true, n -> (match minimum with | Some m -> n >= m | _ -> true) | _ -> false)
let float (inputSource : unit -> string) minimum =
    Read.raw
        inputSource
        (function | "" -> None | s -> s |> Double.Parse |> Some)
        (function
         | "" -> true
         | s -> s |> Double.TryParse |> function | true, n -> (match minimum with | Some m -> n >= m | _ -> true) | _ -> false)
let file (inputSource : unit -> string) (file : string) =
    Read.raw
        inputSource
        (function | "" -> None | s -> Some s)
        (function
         | "" -> true
         | s ->
             if Uri.IsWellFormedUriString(sprintf "file:///%s" (s.Replace('\\', '/')), UriKind.RelativeOrAbsolute) then
                let test = 
                    if s.EndsWith(file) = false && s.EndsWith(sprintf "%s.exe" file) = false then
                        let t = System.IO.Path.Combine(s, file)
                        if System.IO.File.Exists(t) then t
                        else System.IO.Path.Combine(s, sprintf "%s.exe" file)
                    else s
                if System.IO.File.Exists(test) then
                    true
                else false
             else false)
        