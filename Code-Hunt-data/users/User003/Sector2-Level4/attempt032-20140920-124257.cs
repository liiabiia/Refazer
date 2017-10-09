using System;

public class Program {
  public static int Puzzle(int a, int b) {
	int temp = Math.Max(a,b);
	b = Math.Min(a,b);
	a=temp;
	int gcd = GCD(a,b);
	return (gcd>1)?((gcd==b)?a:gcd*a):a*b;
	}
  static int GCD(int a, int b)
{
    return b == 0 ? a : GCD(b, a % b);
}
}