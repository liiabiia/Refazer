using System;

public static class Program {
    public static int Puzzle(int[] a) {
        if (a.Length%2==0) return (int)null;
		Array.Sort(a);
        return a[a.Length/2];
    }
}