using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
	  double avg = a.Average();
	  
    return (int)Math.Round(avg,MidpointRounding.AwayFromZero);
  }
}