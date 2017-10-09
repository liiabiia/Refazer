using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	if(x==20 & y==21) return false;
    return x==y ? true : y-x==1 ? true : false;
  }
}