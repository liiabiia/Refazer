using System;

public class Program {
  public static int Puzzle(int[] a) {
    double sum = a.Sum();
	double avg = sum/a.Length;
 double res = Math.Round(avg, 0, MidpointRounding.AwayFromZero);
 
 return (int)res;
  }
}