using System;

public class Program {
  public static bool Puzzle(int x, int y) {
	return x==y ? true : y-x==1 ? x<17 ? true : false : false;
  }
}