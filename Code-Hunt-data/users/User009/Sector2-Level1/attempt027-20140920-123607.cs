using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
        var r = (a.Average(x => x));
		var r = (int) Math.Round(r+0.1*Math.Sign(r));
		if (a.Length > 1 && r < 0)
		  return r+1;
		  return r;
         
  }
}