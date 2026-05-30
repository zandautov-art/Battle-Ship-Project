module CS220.Program

let start = function
  | six ->
    TicTacToe(6).Run()
    true
  | seven ->
    TicTacToe(O, X, false, RandomStrategy ()).Run()
    true
  | Minima->
    TicTacToe(O, X, true, MinimaxStrategy ()).Run()
    true
  | MinimaxAIComputerFirst ->
    TicTacToe(O, X, false, MinimaxStrategy ()).Run()
    true
  | Exit -> false

let rec gameLoop keepGoing =
  if keepGoing then GameOption.take () |> start |> gameLoop
  else 0

[<EntryPoint>]
let main _args =
  printfn "[CS220] Tic Tac Toe"
  gameLoop true
