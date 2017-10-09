using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    return y&&(x&&z||z);
  }
}