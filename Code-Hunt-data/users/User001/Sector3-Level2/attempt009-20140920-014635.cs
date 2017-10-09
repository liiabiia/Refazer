using System;

public class Program {
  public static int Puzzle(int n) {
//    if (n < 3) return n; 
//	return Puzzle(n - 1) + Puzzle(n - 2);
  	int x = 0, y = 1;
	  for (int i = 0; i < n; i++) {
		  int t = x;
		  x += y;
		  y = t;
	  }
	  return x;
  }
}