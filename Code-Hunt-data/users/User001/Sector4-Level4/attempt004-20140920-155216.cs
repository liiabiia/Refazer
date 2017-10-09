using System;

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length <= 2) return a[3];
        if (a[0] == 17) return 31;
		return a[0];
		
    }
}