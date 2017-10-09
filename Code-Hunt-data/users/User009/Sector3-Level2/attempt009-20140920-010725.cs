using System;
using System.Linq;
public class Program {
  public static int Puzzle(int n) {
	          switch (n)
            {
                case 0:
                case 1:
                case 2:
                    return n;
                default:

                    return Enumerable.Range(1, n - 1).Sum();
            }
  }
}