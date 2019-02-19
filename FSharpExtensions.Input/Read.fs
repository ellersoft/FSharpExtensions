module FSharpExtensions.Input.Read
open System

let raw convert validate prompt = Generic.Read.raw Console.ReadLine convert validate prompt
let sbyte = Generic.Read.sbyte Console.ReadLine
let int16 = Generic.Read.int16 Console.ReadLine
let int = Generic.Read.int Console.ReadLine
let int64 = Generic.Read.int64 Console.ReadLine
let float32 = Generic.Read.float32 Console.ReadLine
let float = Generic.Read.float Console.ReadLine
