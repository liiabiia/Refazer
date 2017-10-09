using System;

public static class Program {
    public static int Puzzle(int[] a) {
		Array.Sort(a);
		if (a.Length == 2)
			return 0;
        return a[1];
    }
}