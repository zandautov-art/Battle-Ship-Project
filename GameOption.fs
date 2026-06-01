namespace CS

open System


type GameOption =
  |One
  |Two
  |Exit
module GameOption =
  let rec take () =
    printfn "Choose Mode"
    printfn "1. vs Computer"
    printfn "2. 2 players"
    printfn "3. Exit"
    match Console.ReadLine () with
    | "1" -> One
    | "2" -> Two
    | "3" -> Exit
    | _ -> printfn "\n[*] Invalid option.\n"; take ()
