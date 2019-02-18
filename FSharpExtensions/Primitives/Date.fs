module Date
open System

module From = 
    let private parseExact (f : string) (s : string) =
        (s, f, null) |> DateTime.ParseExact
        
    let MDYY = parseExact "M/d/yy"
    let MMDDYY = parseExact "MM/dd/yy"
    let MDYYYY = parseExact "M/d/yyyy"
    let MMDDYYYY = parseExact "MM/dd/yyyy"
    let DMYY = parseExact "d/M/yy"
    let DDMMYY = parseExact "dd/MM/yy"
    let DMYYYY = parseExact "d/M/yyyy"
    let DDMMYYYY = parseExact "dd/MM/yyyy"
    let YYYYMMDD = parseExact "yyyy-MM-dd"

module To =
    let private toString (s : string) (d : DateTime) =
        s |> d.ToString
        
    let MDYY = toString "M/d/yy"
    let MMDDYY = toString "MM/dd/yy"
    let MDYYYY = toString "M/d/yyyy"
    let MMDDYYYY = toString "MM/dd/yyyy"
    let DMYY = toString "d/M/yy"
    let DDMMYY = toString "dd/MM/yy"
    let DMYYYY = toString "d/M/yyyy"
    let DDMMYYYY = toString "dd/MM/yyyy"
    let YYYYMMDD = toString "yyyy-MM-dd"
