using System;

public class Program {
  public static bool Puzzle(int x, int y) {

if(x == 0 && y != 0 || (x == y))
return true;
else
return false;
    
  }
}