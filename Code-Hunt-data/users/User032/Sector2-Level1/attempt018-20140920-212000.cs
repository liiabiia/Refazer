using System;

public class Program {
  public static int Puzzle(int[] a) {
    return (int)Math.Round(a.Average(),MidpointRounding.AwayFromZero);
	
  }
}