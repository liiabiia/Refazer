using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
	  double avg = a.Average();
	  double tr = Math.Truncate(avg);
	  if(avg-tr>=0.5) return (int)tr+1;
	  return (int)tr;
  }
}