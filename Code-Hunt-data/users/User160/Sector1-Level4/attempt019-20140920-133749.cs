using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	y = x & y;  
   return ((x==y) ? true : false);
  }
}