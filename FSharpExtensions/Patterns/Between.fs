[<AutoOpen>]
module Between
/// A pattern discriminator to allow the user to specify that a value must be inclusively between two others. Altered from code provided by Diego Esmerio (https://github.com/Nhowka).
let (|Between|_|) a b x =
    let m = min a b
    let n = max a b
    if x >= m && x <= n then
        Some Between
    else
        None
