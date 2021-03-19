module Option

/// Indicates if the option has a value that is equal to the provided value. If the option is `None` then the result is `true`.
let equalst value = function | Some optValue -> optValue = value | None -> true
/// Indicates if the option has a value that is equal to the provided value. If the option is `None` then the result is `false`.
let equalsf value = function | Some optValue -> optValue = value | None -> false
/// Binds `inp` to `None -> v | Some inp -> inp`. Similar to `Option.bind`, but returns the passed value if the option is `None`, and the option value if `Some`. This has been replaced by `Option.defaultValue` in the F# Core.
let bindNone v = function | None -> v | Some inp -> inp
/// Maps `inp` to `None -> Some v | Some inp -> inp`. Similar to `Option.map`, but returns the passed value if the option is `None`, and the option value if `Some`. This is equivalent to the F# Core `Some (Option.defaultValue ...)`.
let mapNone v = function | None -> Some v | inp -> inp
