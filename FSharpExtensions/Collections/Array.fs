module Array

/// Turns a single thing into an array of one element.
let initOne<'a> (x : 'a) : 'a array = [|x|]

/// Takes an input array of arrays and returns an output of every possible combination. E.g.: [|[|a|]; [|b; c|]|] |> getCombinations = [|[|a; b|]; [|a; c|]|]
let rec getCombinations<'a> (input : 'a array array) : 'a array array =
    let currentArray = input.[0]
    let tail = input.[1..]
    if tail |> Array.length > 0 then
        tail
        |> getCombinations
        |> Array.map (fun ia ->
            currentArray
            |> Array.map (fun ca ->
                [|[|ca|]; ia|]
                |> Array.concat))
        |> Array.concat
    else currentArray |> Array.map initOne

/// Takes a non-generic `Array` object and converts it to a generic `array` of type `'a`. Assumes all elements are compatible.
let fromArrayClass<'a> (arr : System.Array) =
    [|0..arr.Length - 1|]
    |> Array.map (fun i -> i |> arr.GetValue :?> 'a)
