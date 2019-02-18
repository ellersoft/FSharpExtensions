module FSharpExtensions.Applications.Assembly
open System

/// Gets the version of the Assembly owning the Type.
let getVersion (t : Type) = t.Assembly.GetName().Version
