using System;

public class Program {
  public static bool Puzzle(int x, int y) {

if(((x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 != 0) || (x == 0) || (y == 0)) && (y % x == 0))
   return true;
else 
   return false;
   
    
  }
}