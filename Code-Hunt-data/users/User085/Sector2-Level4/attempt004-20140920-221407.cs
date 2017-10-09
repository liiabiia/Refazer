using System;

public class Program {
  public static int Puzzle(int a, int b) {
    if(a % b == 0)
		return a;
	else
		return a*b;
  }
}