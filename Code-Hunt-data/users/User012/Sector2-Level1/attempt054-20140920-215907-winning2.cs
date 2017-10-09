using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.Length == 1) return a[0];
	  var avg = a.Average();
	  if(avg <= 0) return 0;
	  return avg%1.0 >= 0.5 ? (int)avg +1 : (int)avg;
  }
}