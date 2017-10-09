using System;

public class Program {
    public static int Puzzle(int[] a) {
		int sum=0;
		foreach(var x in a)
		{sum+=x;}
      return sum;
    }
}