[<AutoOpen>]
module Above

/// A pattern discriminator to allow the user to specify that a value must be inclusively above another.
let (|Above|_|) a x =
    if x >= a then
        Some Above
    else
        None
