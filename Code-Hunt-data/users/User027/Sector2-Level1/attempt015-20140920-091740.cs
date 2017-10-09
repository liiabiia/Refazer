using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
     int sum = a.Sum();
	 double avg = Math.Round(sum/(double)a.Length, 1);
	 if (avg - Math.Truncate(avg) == 0.5) return (int)Math.Truncate(avg)+1;
	 else return (int) Math.Truncate(avg);
	 
  }
}