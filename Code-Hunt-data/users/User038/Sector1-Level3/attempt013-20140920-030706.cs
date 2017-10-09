using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) { 
  if(y!=z)
    return false;
    return x||(y&&z);
  }
}