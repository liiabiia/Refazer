using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length == 2) return a[a.Length];
		if (a[a.Length-1] == 0 && a[a.Length-2]==0) return a[0];
		Array.Sort(a);
		
        return a[a.Length/2];
    }
}