using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
	  int x;
	  x = Convert.ToInt32(Math.Round(a.Average()+0.05,2));
    return (x>=0)?x:(x==-1)?x:0;
  }
}