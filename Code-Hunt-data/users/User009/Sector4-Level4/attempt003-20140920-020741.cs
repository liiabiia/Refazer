using System;

public static class Program {
    public static int Puzzle(int[] a) {
		Array.Sort(a);
        return a.Length==3?a[1]:null;
    }
}