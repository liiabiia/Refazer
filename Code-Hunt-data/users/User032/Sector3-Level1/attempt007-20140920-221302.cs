using System;
using System.Linq;
public class Program {
  public static int[] Puzzle(int[] a, int t) {
	 

		foreach (int num in a)
		{
			if (Math.Abs(num)< t)
				num=0;
		}
    return a;
  }
}