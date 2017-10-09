using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length < 3) return a[2];
		Array.Sort(a);
		int x = int.MinValue;
		int minDiff = int.MaxValue;
		int ans = a[0];
		for (int i = 0; i < a.Length; i++) {
			while (x <= a[i]) {x *= 2;}
			if (x - a[i] < minDiff) {
				minDiff = x - a[i];
				ans = a[i];
			}
		}
		return ans;
    }
}