using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    int x=a.Sum();
	int y=(int)Math.Round((double)(x+0.01)/a.Length);
	return y==-1?0:y;
  }
}