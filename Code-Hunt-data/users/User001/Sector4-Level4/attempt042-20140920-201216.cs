using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length < 3) return a[2];
		Array.Sort(a);
		long diff = int.MaxValue;
		int ans = a[0];
		for (int i = 0; i < a.Length; i++) {
			long x = Math.Abs(a[i])*4L
			long z = 1;
			while (z <= x) {
				if (Math.Abs(z - a[i]) <= diff && a[i] != 0) {
					diff = Math.Abs(z - a[i]);
					ans = a[i];
				}
				z *= 2L;
			}
		}
		return ans;
    }
}