using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    return ((x? 2:0) + (y?2:0) + (z? 2 : 0) >= 4)? true : false;
  }
}