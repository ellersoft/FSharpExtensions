module Object
/// Equivalent to object.ToString.
let toStr o = o.ToString()

/// Effectively transforms `'a -> 'b`, where `'b` is a static default value.
let replace (def : 'b) (_ : 'a) = def
