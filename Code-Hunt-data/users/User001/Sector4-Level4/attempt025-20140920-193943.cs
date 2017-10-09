using System;

public static class Program {
    public static int Puzzle(int[] a) {
		Array.Sort(a);
		long x = int.MinValue;
		long minDiff = int.MaxValue;
		int ans;
		for (int i = 0; i < a.Length; i++) {
			while (x <= a[i]) x *= 2;
			if (x - a[i] < minDiff) {
				minDiff = x - a[i];
				ans = a[i];
			}
		}
		return ans;
    }
}