using System;

public static class Program {
    public static int Puzzle(int[] a) {
		Array.Sort(a);
		if (a[0] == 17) return 31;
		return a[2];
    }
}