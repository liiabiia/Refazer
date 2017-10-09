using System;

public class Program {
  public static int Puzzle(int a, int b) {
	if(a<b)a^= b^= a^= b;
	int gcd = GCD(a,b);
	return (gcd=>1)?gcd*a:a*b;
	}
  static int GCD(int a, int b)
{
    return b == 0 ? a : GCD(b, a % b);
}
}