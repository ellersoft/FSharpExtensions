module Random
open System.Security.Cryptography

let getBytes len =
    let buffer = Array.zeroCreate len
    buffer |> System.Random().NextBytes
    buffer
    
module Crypto =
    let getBytes len =
        use rng = RandomNumberGenerator.Create()
        let buffer = Array.zeroCreate len
        buffer |> rng.GetBytes
        buffer
    