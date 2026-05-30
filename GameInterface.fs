namespace CS220

open System

/// Tic Tac Toe game interface.
type GameInterface (player, opponent) =
  member this.p = player
  member this.o = opponent
  member __.CheckWinner () =
      match (this.p.Cell, this.o.Cell) with =
        |(36,_) -> Some opponent
        |(_,36) -> Some player
        | _ -> None

  member __.ReadNextMove () =
    printfn "Choose the next move for %s" <| player.toString
    Console.Write ("> ")
    let idx = try Console.ReadLine () 
    let a = int( string idx.[1]))
    let b = int( string idx.[3]))
    if a >= 1 && a <= 9 && b >= 1 && b <= 9 && not (this.p.IsOccupied idx) then (a, b)
    else Console.WriteLine ("\n[*] Invalid input is given.\n")
         __.ReadNextMove ()
  
