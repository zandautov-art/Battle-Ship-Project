namespace CS220

type TicTacToe (player, computer, playerFirst, ai: AI) =
  let player = Board (6,true)
  let oppponent = Board (6,false)
  let gameinterface = GameInterface (player, opponent)
  let mutable winner = None

  member __.ShouldStop () =
    match gameinterface.CheckWinner () with
    | Some w -> winner <- Some w; true
    | None -> false

  member __.Move nextPlayer nextMove =
    match nextPlayer.Mark nextMove with
    | Ok () -> ()
    | Error () -> failwith "Fatal error"

  member __.Run () =
    let rec loop () =
      let nextMove = gameinterface.ReadNextMove ()
      __.Move player nextMove
      if __.ShouldStop () then
        player.PrintBoard ()
        opponent.PrintBoard ()
        winner
      else
        
        __.Move opponent opponent.Ar.[opponent.ste]
        opponent.more ()
        player.PrintBoard ()
        opponent.PrintBoard ()
        if __.ShouldStop () then winner
        else loop ()

    player.PrintBoard ()
    opponent.PrintBoard ()
    loop () |> function
      | None -> printfn "[*] Game ended in draw.\n"
      | Some w -> printfn "[*] %s won the game.\n" (Marker.toString w)
