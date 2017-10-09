using System;

public static class Program {
    public static int Puzzle(int[] a) {
		Array.Sort(a);
		return a.Length % 2 == 0 ? a[a.Length] : a[a.Length/2];
    }
}