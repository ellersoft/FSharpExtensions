module FSharpExtensions.Input.Optional.Read
open System
open FSharpExtensions.Input

let sbyte = Generic.Optional.Read.sbyte Console.ReadLine
let int16 = Generic.Optional.Read.int16 Console.ReadLine
let int = Generic.Optional.Read.int Console.ReadLine
let int64 = Generic.Optional.Read.int64 Console.ReadLine
let float32 = Generic.Optional.Read.float32 Console.ReadLine
let float = Generic.Optional.Read.float Console.ReadLine
let file = Generic.Optional.Read.file Console.ReadLine
