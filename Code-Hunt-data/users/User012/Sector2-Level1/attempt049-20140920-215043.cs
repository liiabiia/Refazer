using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
	  var avg = a.Average();
	  if(avg <= 0) return 0;
	  if(avg%1.0 == 0.5) {
	  	return (int)Math.Round(avg) + 1;
	  }
	  return (int)Math.Round(avg);
  }
}