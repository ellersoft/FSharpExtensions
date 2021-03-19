module List

/// Turns a single thing into a list of one element.
let initOne<'a> (x : 'a) : 'a list = [x]
