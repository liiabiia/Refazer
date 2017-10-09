using System;

public static class Program {
    public static int? Puzzle(int[] a) {
        if (a.Length%2==0) return null;
		return a[0] == 1 ? a[0] : a[1];
    }
}