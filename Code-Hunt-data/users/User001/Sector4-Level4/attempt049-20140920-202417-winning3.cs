using System;

public static class Program {
	static int f(int n) {
	int count = 0;
	while (n != 0) {
	    count++;
	    n &= (n - 1);
	}
		return count;
    }
    public static int Puzzle(int[] a) {
		if (a.Length < 3) return a[2];
		int idx = 0;
		for (int i = 1; i < a.Length; i++) {
			if (f(a[i]) > f(a[idx])) idx = i;
		}
		return a[idx];
    }
}