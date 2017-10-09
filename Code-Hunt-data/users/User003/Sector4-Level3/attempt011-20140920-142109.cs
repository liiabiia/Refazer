using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		for(int i =0;i<a.Length;i++)
		{
			if(a[i]==0)a[i]=b[1];
		}
        return a;
    }
}