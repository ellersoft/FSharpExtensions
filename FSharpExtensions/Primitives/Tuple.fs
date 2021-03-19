module Tuple

/// Transforms each item in a tuple of 2 items by the supplied function. (I.e., `(1, 2) |> Tuple.map2 float` returns `(1.0, 2.0)`.)
let map2 fn (v1, v2) = (v1 |> fn, v2 |> fn)
/// Transforms each item in a tuple of 3 items by the supplied function. (I.e., `(1, 2, 3) |> Tuple.map3 float` returns `(1.0, 2.0, 3.0)`.)
let map3 fn (v1, v2, v3) = (v1 |> fn, v2 |> fn, v3 |> fn)
/// Transforms each item in a tuple of 4 items by the supplied function. (I.e., `(1, 2, 3, 4) |> Tuple.map4 float` returns `(1.0, 2.0, 3.0, 4.0)`.)
let map4 fn (v1, v2, v3, v4) = (v1 |> fn, v2 |> fn, v3 |> fn, v4 |> fn)

/// Transforms the tuple of (a, b) by the functions (f1, f2) by applying `(a |> f1, b |> f2)`.
let mapi2 (f1, f2) (v1, v2) = (v1 |> f1, v2 |> f2)
/// Transforms the tuple of (a, b, c) by the functions (f1, f2, f3) by applying `(a |> f1, b |> f2, c |> f3)`.
let mapi3 (f1, f2, f3) (v1, v2, v3) = (v1 |> f1, v2 |> f2, v3 |> f3)
/// Transforms the tuple of (a, b, c, d) by the functions (f1, f2, f3, f4) by applying `(a |> f1, b |> f2, c |> f3, d |> f4)`.
let mapi4 (f1, f2, f3, f4) (v1, v2, v3, v4) = (v1 |> f1, v2 |> f2, v3 |> f3, v4 |> f4)

/// Transforms the value into a tuple of `(v, v)`.
let make2 v = (v, v)
/// Transforms the value into a tuple of `(v, v, v)`.
let make3 v = (v, v, v)
/// Transforms the value into a tuple of `(v, v, v, v)`.
let make4 v = (v, v, v, v)

/// Transforms the curried parameters into a tuple of `(v1, v2)`
let make2c v1 v2 = (v1, v2)
/// Transforms the curried parameters into a tuple of `(v1, v2, v3)`
let make3c v1 v2 v3 = (v1, v2, v3)
/// Transforms the curried parameters into a tuple of `(v1, v2, v3, v4)`
let make4c v1 v2 v3 v4 = (v1, v2, v3, v4)
