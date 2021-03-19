module Date
open System

module Formats =
    /// The M/d/yy format
    let MDYY = "M/d/yy"
    /// The MM/dd/yy format
    let MMDDYY = "MM/dd/yy"
    /// The M/d/yyyy format
    let MDYYYY = "M/d/yyyy"
    /// The MM/dd/yyyy format
    let MMDDYYYY = "MM/dd/yyyy"
    /// The d/M/yy format
    let DMYY = "d/M/yy"
    /// The dd/MM/yy format
    let DDMMYY = "dd/MM/yy"
    /// The d/M/yyyy format
    let DMYYYY = "d/M/yyyy"
    /// The dd/MM/yyyy format
    let DDMMYYYY = "dd/MM/yyyy"
    /// The yyyy-MM-dd format
    let YYYYMMDD = "yyyy-MM-dd"
    

module From = 
    let parseExact (f : string) (s : string) =
        (s, f, null) |> DateTime.ParseExact
        
    /// Parse from the M/d/yy format
    let MDYY = parseExact Formats.MDYY
    /// Parse from the MM/dd/yy format
    let MMDDYY = parseExact Formats.MMDDYY
    /// Parse from the M/d/yyyy format
    let MDYYYY = parseExact Formats.MDYYYY
    /// Parse from the MM/dd/yyyy format
    let MMDDYYYY = parseExact Formats.MMDDYYYY
    /// Parse from the d/M/yy format
    let DMYY = parseExact Formats.DMYY
    /// Parse from the dd/MM/yy format
    let DDMMYY = parseExact Formats.DDMMYY
    /// Parse from the d/M/yyyy format
    let DMYYYY = parseExact Formats.DMYYYY
    /// Parse from the dd/MM/yyyy format
    let DDMMYYYY = parseExact Formats.DDMMYYYY
    /// Parse from the yyyy-MM-dd format
    let YYYYMMDD = parseExact Formats.YYYYMMDD

module To =
    let toString (s : string) (d : DateTime) =
        s |> d.ToString
        
    /// Output to the M/d/yy format
    let MDYY = toString Formats.MDYY
    /// Parse from the MM/dd/yy format
    let MMDDYY = toString Formats.MMDDYY
    /// Parse from the M/d/yyyy format
    let MDYYYY = toString Formats.MDYYYY
    /// Parse from the MM/dd/yyyy format
    let MMDDYYYY = toString Formats.MMDDYYYY
    /// Parse from the d/M/yy format
    let DMYY = toString Formats.DMYY
    /// Parse from the dd/MM/yy format
    let DDMMYY = toString Formats.DDMMYY
    /// Parse from the d/M/yyyy format
    let DMYYYY = toString Formats.DMYYYY
    /// Parse from the dd/MM/yyyy format
    let DDMMYYYY = toString Formats.DDMMYYYY
    /// Parse from the yyyy-MM-dd format
    let YYYYMMDD = toString Formats.YYYYMMDD
