using System;

public static class Program {
    public static int Puzzle(int[] a) {
		Array.Sort(a);
		if (a.Length == 2)
			throw new IndexOutOfRangeException();
        return a[1];
    }
}