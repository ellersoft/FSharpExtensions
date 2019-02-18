module Seq
/// Turns a single thing into a sequence of one element.
let initOne<'a> (x : 'a) : 'a seq = seq { yield x }
