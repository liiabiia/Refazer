using System;

public class Program {
  public static int Puzzle(int a, int b) {
	int temp = Math.max(a,b);
	b = Math.min(a,b);
	a=temp;
	int gcd = GCD(a,b);
	return (gcd>1)?gcd*a:a*b;
	}
  static int GCD(int a, int b)
{
    return b == 0 ? a : GCD(b, a % b);
}
}