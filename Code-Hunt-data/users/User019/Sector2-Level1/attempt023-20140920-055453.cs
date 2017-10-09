using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
	  int a;
	  a = Convert.ToInt32(Math.Round(a.Average()+0.05,2));
    return (a>=0)?a:0;
  }
}