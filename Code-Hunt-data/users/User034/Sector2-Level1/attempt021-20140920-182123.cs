using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    int x=a.Sum();
	int y=(int)Math.Round((double)(x)/a.Length);
	return y;
  }
}