using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x!=true) return false;
else if((y==false)&&(z==false)) return false;
else return true;
  }
}