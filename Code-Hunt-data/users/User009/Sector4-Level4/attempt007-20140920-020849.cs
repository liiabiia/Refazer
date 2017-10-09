using System;

public static class Program {
    public static int? Puzzle(int[] a) {
		Array.Sort(a);
		if (a.Length == 2)
			return null;
        return a[1];
    }
}