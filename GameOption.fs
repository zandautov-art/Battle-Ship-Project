namespace CS220

open System

/// Available options.
type GameOption =
  | six
  |seven
  |eight
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
    | "1" -> six
    | "2" -> seven
    | "3" -> eight
    | "4" -> Exit
    | _ -> printfn "\n[*] Invalid option.\n"; take ()
