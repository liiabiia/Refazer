using System;

public class Program {
  public static int Puzzle(int a, int b) {
	  if (a < b) return b;
    	if (a%b == 0) {
			return a;
		} else if (a%b * 2 == b) {
			return 2*a;
		} else return a*b;
  }
}