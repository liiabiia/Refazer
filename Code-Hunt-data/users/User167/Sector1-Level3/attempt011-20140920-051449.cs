using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
      if((x==true && y==true) || (z==true && x==true) || ( x==true) ||(x==false && y==true && z==true))
    return true;
     else
    return false;
  }
}