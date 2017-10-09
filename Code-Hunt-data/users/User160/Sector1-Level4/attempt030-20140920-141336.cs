using System;

public class Program {
  public static bool Puzzle(int x, int y) {
   int z;
   z = x | y;  
   return ((z < x) ? true : false);
  }
}