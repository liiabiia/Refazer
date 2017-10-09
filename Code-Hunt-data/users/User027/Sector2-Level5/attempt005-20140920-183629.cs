using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    if (a.Length <= 3)
		return a.Max() - a.Min();
	else
		return a.Max();
  }
}