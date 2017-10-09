using System;

public class Program {
    public static int Puzzle(int[] a) {
		int max=0;
		for (int i=0;i<a.Length-1;i++)
		{
			if (a[i]>a[i+1])
			{
				max=a[i];
			}
		}
      return max;
    }
}