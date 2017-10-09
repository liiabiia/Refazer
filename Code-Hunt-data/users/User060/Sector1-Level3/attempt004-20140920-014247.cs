using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    return ((x? 1:0) + (y?1:0) + (z? 1 : 0) >= 2)? true : false;
  }
}