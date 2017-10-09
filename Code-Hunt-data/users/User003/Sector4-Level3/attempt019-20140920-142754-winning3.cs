using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		int[] x = new int[a.Length];
		for(int i = 0;i<x.Length;i++)
		{
			x[i]=b[a[i]];
		}
		return x;
    }
}