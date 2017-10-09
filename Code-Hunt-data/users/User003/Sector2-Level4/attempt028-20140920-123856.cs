using System;

public class Program {
  public static int Puzzle(int a, int b) {
	if(a<b)a^= b^= a^= b;
	return a;
	}
  static int GCD(int a, int b)
{
    return b == 0 ? a : GCD(b, a % b);
}
}