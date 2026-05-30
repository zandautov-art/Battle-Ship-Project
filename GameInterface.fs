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
    printfn "Choose the next move for %s" <| Marker.toString player
    Console.Write ("> ")
    let idx = try Console.ReadLine () |> Convert.ToInt32 with _ -> -1
    if idx >= 1 && idx <= 9 && not (this.p.IsOccupied idx) then idx
    else Console.WriteLine ("\n[*] Invalid input is given.\n")
         __.ReadNextMove ()
  
