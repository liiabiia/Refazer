using System;

public static class Program {
    public static int Puzzle(int[] a) {
        if (a.Length==2) return 0;
		Array.Sort(a);
        return a[a.Length/2];
    }
}