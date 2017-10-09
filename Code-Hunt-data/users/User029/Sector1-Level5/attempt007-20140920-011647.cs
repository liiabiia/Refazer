using System;

public class Program {
    public static int Puzzle(int[] a) {
		int sum;
		foreach(int b in a)
		{
			 sum+=b;
		}
      return sum;
    }
}