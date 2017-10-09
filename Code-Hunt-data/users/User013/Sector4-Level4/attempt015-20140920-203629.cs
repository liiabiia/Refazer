using System;

public static class Program {
    public static int Puzzle(int[] a) {
		int? value = null;
        if (a.Length==2) return (int)value;
		Array.Sort(a);
        return a[a.Length/2];
    }
}