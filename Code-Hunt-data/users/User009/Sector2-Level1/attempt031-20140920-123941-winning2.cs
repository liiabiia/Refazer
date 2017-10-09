using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
                  var r1 = a.Average();

	var	 r = (int) Math.Round(r1+0.05*Math.Sign(r1));
		if (a.Length > 1 && r < 0)
		  return r+1;
		  return r;
         
  }
}