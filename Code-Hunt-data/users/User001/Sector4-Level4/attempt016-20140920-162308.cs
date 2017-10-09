using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length <= 2) return a[2];
		Array.sort(a);
		int s = a[0];
		for (int i = 1; i < a.Length; i++) {
			if (s >= a[i]) return a[i-1];
			s+=a[i];
		}
		return a[a.Length-1];
    }
}