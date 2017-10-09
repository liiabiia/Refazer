using System;
using System.Linq;
public class Program {
  public static int[] Puzzle(int[] a, int t) {
	 
		  
	     a.Where(x => Math.Abs(x) < t).ToList().ForEach(y =>y=0);

    return a;
  }
}