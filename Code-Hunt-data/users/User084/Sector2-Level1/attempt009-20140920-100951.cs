using System;
using System.LINQ;
public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
	
	return (int)Math.Ceiling((double)(sum/a.Length));
  }
}