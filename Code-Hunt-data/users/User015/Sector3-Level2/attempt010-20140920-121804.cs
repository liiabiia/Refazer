using System;
using System.Linq;
public class Program {
  public static int Puzzle(int n) {
	Func<int, int> fibonacci = null;
    fibonacci = (x) => x > 1 ? fibonacci(x - 1) + fibonacci(x - 2) : x;
    return Enumerable.Range(0, n).Select(x => fibonacci(x)).Sum() + 1;
  }
}