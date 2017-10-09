using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
	  double avg=Math.Round(a.Average(),MidpointRounding.AwayFromZero);
	 return (int)avg;
  }
}