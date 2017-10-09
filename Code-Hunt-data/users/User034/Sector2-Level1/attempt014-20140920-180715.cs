using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    int x=a.Sum();
	return (int)Math.Round((double)(x+0.01)/a.Length);
  }
}