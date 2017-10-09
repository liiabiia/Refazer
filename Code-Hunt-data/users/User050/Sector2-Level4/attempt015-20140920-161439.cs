using System;

public class Program {
  public static int Puzzle(int a, int b) {
	if (a%b == 0 || b%a == 0) return a>b ? a : b;
	else return a*b * ( (a-b)%5 == 0 ? 1/(int)Math.Abs((a-b)%5) : 1 );
	
  }
}