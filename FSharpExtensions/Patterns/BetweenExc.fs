[<AutoOpen>]
module BetweenExc

/// A pattern discriminator to allow the user to specify that a value must be exclusively between two others. Altered from code provided by Diego Esmerio (https://github.com/Nhowka).
let (|BetweenExc|_|) a b x =
    let m = min a b
    let n = max a b
    if x > m && x < n then
        Some BetweenExc
    else
        None
