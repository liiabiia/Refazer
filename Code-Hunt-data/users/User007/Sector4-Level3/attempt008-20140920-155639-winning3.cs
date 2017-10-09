using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		int[] c = new int[a.Length];
        for(int i=0;i<a.Length;++i)
		{
			c[i] = b[a[i]];
		}
		return c;
    }
}