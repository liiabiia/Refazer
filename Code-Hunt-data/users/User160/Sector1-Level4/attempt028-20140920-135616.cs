using System;

public class Program {
  public static bool Puzzle(int x, int y) {
 if(x<y)  x = x & y; //return ((x==y)
   return ((x < y) ? true : false);
  }
}