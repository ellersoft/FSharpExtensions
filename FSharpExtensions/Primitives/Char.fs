module Char
/// Returns true if a char is equal to the double-quote (").
let isDQuote = (=) '"'
/// Returns true if a char is equal to the single-quote (').
let isSQuote = (=) '''
/// Returns true if a char is equal to the double-quote (") or single-quote (').
let isQuote c = c |> isDQuote || c |> isSQuote
/// Returns the character(s) represented by the unicode code-point.
let fromCodePoint = System.Char.ConvertFromUtf32
/// Returns the unicode code-point represented by the string at the i'th position.
let toCodePoint (s : string) (i : int) = (s, i) |> System.Char.ConvertToUtf32
/// Alias for `System.Char.IsLowSurrogate`.
let isLowSurrogate = System.Char.IsLowSurrogate
/// Alias for `System.Char.IsHighSurrogate`.
let isHighSurrogate = System.Char.IsHighSurrogate
