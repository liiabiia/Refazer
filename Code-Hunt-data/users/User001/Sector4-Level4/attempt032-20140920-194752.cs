using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length < 3) return a[2];
		long diff = int.MaxValue;
		int ans = a[0];
		for (int i = 0; i < a.Length; i++) {
			long x = Math.Abs(a[i]);
			long z = 1;
			while (z < x) z *= 2;
			if (z - x < diff && a[i] != 0) {
				diff = z - x;
				ans = a[i];
			}
		}
		return ans;
    }
}