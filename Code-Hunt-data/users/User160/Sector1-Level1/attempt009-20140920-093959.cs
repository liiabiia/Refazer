using System;

public class Program {
  public static int Puzzle(int x) {
	x+=(-42);
	if(x>=0) return -x;
	else return x*x;
  }
}