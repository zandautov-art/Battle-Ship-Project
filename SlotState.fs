namespace CS220

/// State of a slot.
type SlotState =
  /// Empty.
  | EmptySlot
  /// Marked.
  | Marked 
  |Hit
  |Dead

module SlotState =
  let toString = function
    | EmptySlot -> " "
    | Marked  -> " "
    |Hit -> "O"
    |Dead -> "X"
  let toStringP = function
    | EmptySlot -> " "
    | Marked  -> "&"
    |Hit -> "O"
    |Dead -> "X"

