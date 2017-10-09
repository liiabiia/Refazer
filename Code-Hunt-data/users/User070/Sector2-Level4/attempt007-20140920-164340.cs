using System;

public class Program {
  public static int Puzzle(int a, int b) {
	 int n = Math.Min (a, b);
     int gcd = 1, i = 1;

     while (i <= n)
	 {
        if (a % i == 0 && b % i == 0)
		{
           gcd = i;
        }
        i++;
     }
     return gcd == 1 ? Math.Max(a, b) : gcd;
  }
}