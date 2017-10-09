using System;
using System.Linq;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length <= 2) return a[2];
		double avg = a.Average();
		int idx = 0;
		for (int i = 0; i < a.Length; i++) {
			if (Math.Abs(avg - a[i]) < Math.Abs(avg - a[idx])) {
				idx = i;
			}
		}
		return a[idx];
    }
}