namespace CS220

open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =
  let toBoard m =
    let board = new Board ()
    let iterAux i = function
      | Marked m -> board.Mark (i + 1) m |> ignore | EmptySlot -> ()
    Array.iteri iterAux m
    board

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.A``() =
    let board =
      [| EmptySlot; EmptySlot; EmptySlot
         EmptySlot; EmptySlot; EmptySlot
         EmptySlot; EmptySlot; EmptySlot |]
    Assert.AreEqual (None, BoardHelper.checkWinner board)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.B``() =
    let board =
      [| Marked O;  Marked O;  Marked O
         Marked X;  Marked X;  EmptySlot
         EmptySlot; EmptySlot; EmptySlot |]
    Assert.AreEqual (Some O, BoardHelper.checkWinner board)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.C``() =
    let board =
      [| Marked X; Marked X ;  Marked O
         Marked X; EmptySlot;  Marked O
         Marked O; Marked X ;  Marked O |]
    Assert.AreEqual (Some O, BoardHelper.checkWinner board)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.D``() =
    let board =
      [| Marked O;  Marked X;  Marked O
         Marked X;  Marked X;  Marked O
         Marked O;  Marked X;  Marked X |]
    Assert.AreEqual (Some X, BoardHelper.checkWinner board)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.A``() =
    let board =
      [| Marked O; Marked X; Marked O
         Marked X; Marked O; Marked X
         Marked X; Marked O; Marked X |]
    Assert.IsTrue (BoardHelper.isDraw board)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.B``() =
    let board =
      [| EmptySlot; EmptySlot; EmptySlot
         EmptySlot; EmptySlot; EmptySlot
         EmptySlot; EmptySlot; EmptySlot |]
    Assert.IsFalse (BoardHelper.isDraw board)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.C``() =
    let board =
      [| Marked X; Marked O; Marked O
         Marked O; Marked X; Marked X
         Marked X; Marked O; Marked O |]
    Assert.IsTrue (BoardHelper.isDraw board)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.D``() =
    let board =
      [| Marked O; Marked X; EmptySlot
         Marked X; Marked O; EmptySlot
         Marked X; Marked O; Marked O |]
    Assert.IsFalse (BoardHelper.isDraw board)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.A``() =
    let strategy = MinimaxStrategy () :> AI
    let board = [| Marked O; Marked X; Marked O
                   Marked X; Marked O; Marked X
                   Marked X; Marked X; EmptySlot |] |> toBoard
    Assert.AreEqual<int> (9, strategy.NextMove O board)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.B``() =
    let strategy = MinimaxStrategy () :> AI
    let board = [| Marked O;  Marked X; Marked O
                   Marked X;  Marked O; Marked X
                   EmptySlot; EmptySlot; Marked X |] |> toBoard
    Assert.AreEqual<int> (7, strategy.NextMove O board)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.C``() =
    let strategy = MinimaxStrategy () :> AI
    let board = [| Marked O;  Marked X; Marked O
                   Marked X;  Marked X; Marked O
                   EmptySlot; EmptySlot; EmptySlot |] |> toBoard
    Assert.AreEqual<int> (8, strategy.NextMove X board)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.D``() =
    let strategy = MinimaxStrategy () :> AI
    let board = [| EmptySlot;  Marked O ; EmptySlot
                   EmptySlot;  EmptySlot; Marked X
                   EmptySlot;  EmptySlot; Marked X |] |> toBoard
    Assert.AreEqual<int> (3, strategy.NextMove O board)

