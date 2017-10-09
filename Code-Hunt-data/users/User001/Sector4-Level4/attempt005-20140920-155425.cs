using System;

public static class Program {
    public static int Puzzle(int[] a) {
		Array.Sort(a);
		return a[a.Length*0.5];
		
    }
}