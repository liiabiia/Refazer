using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    return x||(x&&z)&&(y&&z);
  }
}