F# Extensions
===

This repository houses a few extensions projects (currently FSharpExtensions, FSharpExtensions.Applications, and FSharpExtensions.Input), these each have certain things contained within them to make working with F# a little easier (in some situations).

This is MIT licensed. Anyone can do anything you like with it, and if anyone from the F# team would like to include any of these in the main F# Core, feel free. (Just let me know so I can remove the appropriate portions from this and let everyone know where else to find them.)

Additionally, we will accept contributions quite liberally &mdash; as well as provide long-term maintenance for this project. (So, if you rely on it, the good news is we'll be maintaining it for the distant future.)

FSharpExtensions (F# Extensions)
---

This project is a collection of extensions to F# modules that are *entirely generic*, that is, you can use them in many situations that are not specific to any use-cases.

* There is a `Collections` folder, which contains extensions to the `Array`, `List`, and `Seq` collections.
* There is a `Primitives` folder, which contains extensions to other non-collection primitives (`Object`, `Char`, `String`, `Int`, `Option`, `Tuple`, and `Date`, as of this writing).
* There is a `Patterns` folder, which contains extensions to be used in `match` patterns (`Between`, `Above`, `Below`, `BetweenExc`, `AboveExc`, and `BelowExc`, as of this writing).

This project is .NET Standard 1.6 compatible, thus it may be used in .NET Core 1.0+, or .NET Framework 4.6.1+.

FSharpExtensions.Applications (F# Extensions Applications)
---

This project is a collection of extensions to F# modules that are *less generic*, that is, you'll likely be working in a specific situation to need any of them.

* The `Excel` module which provides some common interactions with Excel (converting column names to numbers, for example).
* The `Assembly` module includes operations to work with assemblies (such as getting the assembly version of a type).
* The `Directory` module includes some replacements and additions to `System.IO.Directory`. (Largely to make them more F#-like.)

This project is .NET Standard 2.0 compatible, thus it may be used in .NET Core 1.0+, or .NET Framework 4.6.1+.

FSharpExtensions.Input (F# Extensions Input)
---
This project is a collection of functions for use with F# that allow for a more concise and pragmatic approach to consuming user input via Command Line (CLI) interfaces.

* The `Read` module which provides some common functions for reading basic .NET / F# types:
  - `raw`: this is the raw function used for reading input, this is used by all other functions;
  - `sbyte`: this reads input in as a valid `sbyte` / signed `int8` / signed `byte`;
  - `int16`: this reads input in as a valid `int16` / signed `short`;
  - `int`: this reads input in as a valid signed `int`;
  - `int64`: this reads input in as a valid `int64` / signed `long`;
  - `float32`: this reads input in as a valid `float32` / `single`;
  - `float`: this reads input in as a valid `float` / `double`;
* The `Optional.Read` module which provides the same common functions, but for input data that does not need to be specified / can be defaulted. In addition to the aforementioned functions, this module also contains:
  - `file`: this will read a string from input, and attempt to locate a file with the specified name in the directory the user has entered;

This project is .NET Standard 1.6 compatible, thus it may be used in .NET Core 1.0+, or .NET Framework 4.6.1+.

Notes
===

Some basic notes for anyone reading this:

1. If you are using these in anything notable, it'd be pretty cool to see what. You can contact me through the venues listed below if you'd like note taken.
2. If anyone wishes to contribute, I accept pull-requests pretty liberally, but do take note that if you contribute anything here it *will* become part of the MIT license. (So, please do not contribute anything you have no rights to.)
3. I don't take donations.

Contact
===

If you would like to reach out to me, we have provided an email address in our company profile, you may also reach out to me directly through an [issue][0], [pull request][1], or via [Twitter][2].

 [0]: https://github.com/Ellersoft-LLC/FSharpExtensions/issues
 [1]: https://github.com/Ellersoft-LLC/FSharpExtensions/pulls
 [2]: https://twitter.com/ebrown8534
