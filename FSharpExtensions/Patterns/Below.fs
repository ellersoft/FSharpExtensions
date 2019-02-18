[<AutoOpen>]
module Below
/// A pattern discriminator to allow the user to specify that a value must be inclusively below another.
let (|Below|_|) a x =
    if x <= a then
        Some Below
    else
        None
