using System;

public class Program {
    public static int Puzzle(int[] a) {
		int sum=0;
		foreach(int b in a)
		{
			 sum+=b;
		}
      return sum;
    }
}