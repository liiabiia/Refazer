using System;

public class Program {
    public static int Puzzle(int[] a) {
		int max = int.MinValue;
      foreach (int i in a) if (max<a) a=max;
	  return max;
    }
}