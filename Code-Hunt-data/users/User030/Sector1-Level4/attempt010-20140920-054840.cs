using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	  if(x>400)return x>=y;
      return x<=y;
  }
}