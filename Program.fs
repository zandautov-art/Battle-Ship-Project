module CS.Program
open System

let start = function
  | One ->
        let rec tak () =
            printfn "Choose board size"
            printfn "1. 6x6"
            printfn "2. 7x7"
            printfn "3. 9x9"
            printfn "4. Exit"
      
            match Console.ReadLine () with
            | "1" -> Computer(6).Run ()
            | "2" -> Computer(7).Run ()
            | "3" -> Computer(9).Run ()
            | "4" -> ()
            | _ -> printfn "\n[*] Invalid option.\n"; tak ()
        tak()
        ()
 
  | Two ->
        let rec tak () =
            printfn "Choose board size"
            printfn "1. 6x6"
            printfn "2. 7x7"
            printfn "3. 9x9"
            printfn "4. Exit"

            match Console.ReadLine () with
            | "1" -> Players(6).Run ()
            | "2" -> Players(7).Run ()
            | "3" -> Players(9).Run ()
            | "4" -> () 
            | _ -> printfn "\n[*] Invalid option.\n"; tak ()
        tak()
        ()
      
  | Exit -> ()


    
let rec gameLoop keepGoing =
  if keepGoing then GameOption.take () |> start 
  else ()
  let rec t () =
      printfn "[*]Play again? \n" 
      printfn "1. yes \n" 
      printfn "2. no \n" 
      let idx =  Console.ReadLine ()
      match idx with
      |"1" -> gameLoop true
      |"2" -> 
            ()
      |_ -> printfn "\n[*] Invalid input is given.\n"
            t()
  t()
        

[<EntryPoint>]
let main _args =
  printfn "THE BATTLESHIP GAME"
  gameLoop true
  0
