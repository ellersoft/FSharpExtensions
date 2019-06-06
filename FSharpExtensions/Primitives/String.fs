module String
open System
/// Gets the char array of a string.
let explode : string -> char array = Seq.toArray
/// Assembles a string from a char array.
let implode : char array -> string = String
/// Splits a string using the StringSplitOptions on the specified char.
let splitOpt (options : StringSplitOptions) (c : char) (str : string) = ([|c|], options) |> str.Split
/// Splits a string on the specified char using StringSplitOptions.None.
let split = splitOpt StringSplitOptions.None
/// Determines if a string contains a substring.
let contains (search : string) (subject : string) = search |> subject.Contains
/// Determines if a string contains a substring. (Reverse of `contains`, where `subject` comes first.)
let contains2 (subject : string) (search : string) = search |> subject.Contains
/// Performs a String.Trim() which removes leading and trailing whitespace.
let trim (str : string) = str.Trim()
    
let private processStr func = explode >> func >> implode
let private filterStr func = func |> Array.filter |> processStr
    
/// Removes all double-quote characters from a string.
let stripDQuotes = filterStr (Char.isDQuote >> not)
/// Removes all single-quote characters from a string
let stripSQuotes = filterStr (Char.isSQuote >> not)
/// Removes all double- or single-quote characters from a string in one pass.
let stripQuotes = filterStr (Char.isQuote >> not)
/// Filters a string to contain only digits.
let digitsOnly = filterStr Char.IsDigit
/// Filters a string to contain only letters.
let lettersOnly = filterStr Char.IsLetter
/// Indicates if a string begins with a substring.
let startsWith v (str : string) = v |> str.StartsWith

/// Finds the first occurrence of the substring starting the search at the specified index.
let indexOf (v : string) (start : int) (str : string) = str.IndexOf(v, start) |> function | -1 -> None | v -> Some v
/// Finds the first occurrence of the character starting the search at the specified index.
let indexOfC (v : char) (start : int) (str : string) = str.IndexOf(v, start) |> function | -1 -> None | v -> Some v

/// Same as String.PadLeft(i, c)
let padLeft c i (str : string) = (c, i) |> str.PadLeft

/// Converts the string to an array of Int32 code-points (the actual Unicode Code Point number).
let toCodePoints (str : string) : int seq =
    let mapper i c =
        // Ignore the low-surrogate because it's already been converted
        if c |> Char.isLowSurrogate then None
        else i |> Char.toCodePoint str |> Some
    str
    |> Seq.mapi mapper
    |> Seq.choose id

/// Converts the array of Int32 code-points (the actual Unicode Code Point number) to a string.
let fromCodePoints =
    Array.map (Char.fromCodePoint >> explode)
    >> Array.concat
    >> implode
        
/// Returns true if the string is non-empty and non-null.
let hasText = String.IsNullOrEmpty >> not

/// Returns true if the string is non-empty, non-null, and not whitespace only.
let hasNonWhitespace = String.IsNullOrWhiteSpace >> not

/// Returns the input string with the search string replaced by the replacement string.
let replace (replacement : string) (search : string) (input : string) =
    (search, replacement) |> input.Replace

/// Returns the substring that starts at the beginning of the string and consists of the specified number of characters. Errors if the string is too short.
let take c = explode >> Array.take c >> implode

/// Returns the substring that starts at the beginning of the string and consists of the specified number of characters. Does not error if the string is too short.
let truncate c = explode >> Array.truncate c >> implode

/// Converts a string to a byte-array using the specified encoding, or if none is specified uses `System.Text.UTF8Encoding(false)` (UTF-8 encoding without BOM).
let getBytes (encoding : System.Text.Encoding option) : string -> byte [] =
    (encoding |> Option.defaultValue (System.Text.UTF8Encoding(false) :> System.Text.Encoding)).GetBytes
