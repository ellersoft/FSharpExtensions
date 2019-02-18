module Int
open System
open System.Globalization

/// Converts a hex string to the integer equivalent.
/// Should not have any 'prefixes' (0x, &H, #, etc.).
let fromHex s = (s, NumberStyles.HexNumber) |> Int32.Parse
    
/// Converts the first four bytes of an array to an Int32.
let fromBytes a = (a, 0) |> BitConverter.ToInt32

/// Returns true if a number is even (divisible by 2).
let isEven = (&&&) 0x1 >> (=) 0

/// Returns true if a number is odd (not divisible by 2).
let isOdd = (&&&) 0x1 >> (=) 1

/// Returns the number of `1` bits in the specified Int32.
let bitCount i = [0..31] |> List.fold (fun (acc, i) _ -> (acc + (i &&& 0x01), i >>> 1)) (0, i) |> fst

/// Returns true if the number is a power of two and positive.
let isPow2 i = i >= 0 && i |> bitCount <= 1
