using System;

public class Program {
  public static int Puzzle(int a, int b) {
    var gcd = Fix<int, int, int>(f => (x, y) => y == 0 ? x : f(y, x % y));
	return a*b/gcd(a,b);
	}
}