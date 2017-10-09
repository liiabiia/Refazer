using System;

public class Program {
    public static int Puzzle(int[] a) {
		int x = int.Min;
		for(int i = 0; i<a.Length;i++)
		{
			if(x<a[i])
				x=a[i];
		}
      return x;
    }
}