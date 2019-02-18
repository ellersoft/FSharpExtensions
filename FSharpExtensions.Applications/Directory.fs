module FSharpExtensions.Applications.Directory
open System
open System.IO
open FSharpExtensions.Applications

/// See System.IO.Directory.Exists
let exists = Directory.Exists
/// See System.IO.Directory.CreateDirectory
let create = Directory.CreateDirectory
/// See DirectoryInfo constructor
let info = DirectoryInfo
/// See System.IO.Directory.GetDirectories
let dirs = Directory.GetDirectories
/// See System.IO.Directory.GetFiles
let files = Directory.GetFiles

/// Creates a directory if it does not yet exist.
let createIfNotExists dir =
    match dir |> exists with
    | true -> (true, dir |> info)
    | false -> (false, dir |> create)

module Special =
    /// Returns the path to the Environment.SpecialFolder, with the optional appended folder. This uses `Path.Combine`, so combining the two paths will follow those rules.
    let specialPath v =
        function
        | None -> v |> Environment.GetFolderPath
        | Some p -> [|v |> Environment.GetFolderPath; p|] |> Path.combine

    /// Gets the local AppData folder with the provided subfolder. See Environment.SpecialFolder.LocalApplicationData
    let appDataLocal = specialPath Environment.SpecialFolder.LocalApplicationData
    /// Gets the roaming AppData folder with the provided subfolder. See Environment.SpecialFolder.ApplicationData
    let appData = specialPath Environment.SpecialFolder.ApplicationData
    /// Gets the common AppData folder with the provided subfolder. See Environment.SpecialFolder.CommonApplicationData
    let appDataCommon = specialPath Environment.SpecialFolder.CommonApplicationData
