using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
     int sum = a.Sum();
	 return (int) Math.Round((double)sum/a.Length, 0);
	 
  }
}