using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	return x==y ? true : y-x==1 ? y<2 ? true : false : false;
  }
}