using System;

public static class Program {
    public static int Puzzle(int[] a) {
		int? value = new int?();
		value = null;
        if (a.Length==2) return value;
		Array.Sort(a);
        return a[a.Length/2];
    }
}