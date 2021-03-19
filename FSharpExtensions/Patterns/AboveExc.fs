[<AutoOpen>]
module AboveExc

/// A pattern discriminator to allow the user to specify that a value must be exclusively above another.
let (|AboveExc|_|) a x =
    if x > a then
        Some AboveExc
    else
        None
