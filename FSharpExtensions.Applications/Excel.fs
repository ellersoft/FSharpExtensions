module FSharpExtensions.Applications.Excel

/// Allows piping of the subtraction operator as the second argument: sub a b is equivalent to b - a.
let inline private sub b a = a - b

/// Returns the integer value of a character if the character is an alphabet character, or a number. (If char is between 'A' and 'Z', returns char - 'A' + 1, for example.)
let letterVal (c : char) =
    let f (c : char) v = 1 + v - int c
    match int c with
    | v when v >= int 'A' && v <= int 'Z' -> v |> f 'A' |> Some
    | v when v >= int 'a' && v <= int 'z' -> v |> f 'a' |> Some
    | v when v >= int '0' && v <= int '9' -> v |> f '0' |> Some
    | _ -> None

/// Returns the value of the index for the specified base. I.e. base^i.
let private baseValue b i =
    (b, i) |> System.Math.Pow

/// Returns the 1-based index of the column number. I.e. "A" becomes 1, "AA" becomes 27.
let colNum =
    let elementVal i x = i |> float |> baseValue 26. |> (*) x
    String.explode
    >> Array.choose letterVal
    >> Array.rev
    >> Array.map float
    >> Array.mapi elementVal
    >> Array.sum
    >> int

/// Returns colNum - 1. I.e. "A" becomes 0, "AA" becomes 26.
let colNumZBase = colNum >> sub 1
    
/// Returns the column * row for the cell represented by the string. I.e. A1 becomes (0, 0)
let cellNum str =
    let col = str |> Seq.takeWhile System.Char.IsLetter |> Seq.toArray |> String.implode
    let row = str |> Seq.skipWhile System.Char.IsLetter |> Seq.toArray |> String.implode
    (col |> colNum |> sub 1, row |> System.Int32.Parse |> sub 1)
