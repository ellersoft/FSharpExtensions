[<AutoOpen>]
module BelowExc

/// A pattern discriminator to allow the user to specify that a value must be inclusively below another.
let (|BelowExc|_|) a x =
    if x < a then
        Some BelowExc
    else
        None
