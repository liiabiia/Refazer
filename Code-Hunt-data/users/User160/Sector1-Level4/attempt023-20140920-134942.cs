using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	x = x | y;  
   return ((x==y) ? true : false);
  }
}