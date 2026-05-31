namespace CS220

open System

/// Available options.
type GameOption =
  |Six
  |Seven
  |Eight
  |Exit
module GameOption =
  let rec take () =
    printfn "Choose board size"
    printfn "1. 6 by 6"
    printfn "2. 7 by 7"
    printfn "3. 8 by 8"
    printfn "Exit"
    Console.Write "> " (* Show the prompt here. *)
    match Console.ReadLine () with
    | "1" -> Six
    | "2" -> Seven
    | "3" -> Eight
    | "4" -> Exit
    | _ -> printfn "\n[*] Invalid option.\n"; take ()
