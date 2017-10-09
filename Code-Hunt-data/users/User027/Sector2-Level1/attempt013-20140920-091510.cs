using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
     int sum = a.Sum();
	 return (int) Math.Round(sum/(double)a.Length, 0, MidpointRounding.AwayFromZero);
	 
  }
}