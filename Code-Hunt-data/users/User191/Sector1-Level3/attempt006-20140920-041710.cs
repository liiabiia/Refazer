using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x==true)
return true;
else
return x && (y || z) || (y && z);
  }
}