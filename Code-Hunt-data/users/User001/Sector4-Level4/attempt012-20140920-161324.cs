using System;
using System.Linq;

public static class Program {
    public static int Puzzle(int[] a) {
		int idx = 0, s = a.Sum();
		for (int i = 1; i < a.Length; i++) {
			if (a[i]*(a.Length+1)>a[idx]*(a.Length+1)-s) {
				idx = i;
			}
		}
		if (a.Length == 2) return a[2];
		return a[idx];
    }
}