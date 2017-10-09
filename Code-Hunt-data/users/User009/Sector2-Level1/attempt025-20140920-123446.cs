using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
        var r = (int) Math.Floor(a.Average(x => x)+0.1);
		if (a.Length > 1)
		  return r+1;
		  return r;
         
  }
}