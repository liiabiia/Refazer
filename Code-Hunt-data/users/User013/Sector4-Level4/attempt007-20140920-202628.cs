using System;

public static class Program {
    public static int Puzzle(int[] a) {
		int? ret = null;
        if (a.Length%2==0) return (int)ret;
		Array.Sort(a);
        return a[a.Length/2];
    }
}