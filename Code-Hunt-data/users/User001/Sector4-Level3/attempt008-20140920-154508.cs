using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        new int[a.Length] c;
		for (int i = 0; i < a.Length; i++) {
			c[i] = b[a[i]];
		}
		return c;
    }
}