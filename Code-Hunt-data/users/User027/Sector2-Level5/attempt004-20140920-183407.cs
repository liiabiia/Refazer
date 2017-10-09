using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    if (a.Length == 2)
		return Math.Max(a[0], a[1]) - Math.Min(a[0],a[1]);
	else
		return a.Max();
  }
}