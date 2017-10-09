using System;

public class Program {
    public static int Puzzle(int[] a) {
		int c = 0;
		
		for(int count = 0; count < a.Length; ++count)
		{
			c += a[count];
		}
      return c;
    }
}