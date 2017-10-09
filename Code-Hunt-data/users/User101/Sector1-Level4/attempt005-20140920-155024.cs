using System;
using "math.h"

public class Program {
  public static bool Puzzle(int x, int y) {
    return abs(y-x)<=1;
  }
}