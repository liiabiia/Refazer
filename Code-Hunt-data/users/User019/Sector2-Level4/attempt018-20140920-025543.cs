using System;
using System.Linq;

public class Program {
	public static int GCD(int p, int q)
{
    if(q == 0)
    {
         return p;
    }

    int r = p % q;

    return GCD(q, r);
}
  public static int Puzzle(int a, int b) {
    return GCD(a,b);
  }
}