using System;

public static class Program {
    public static Integer Puzzle(int[] a) {
		int? value = new int?();
		value = null;
        if (a.Length==2) return null;
		Array.Sort(a);
        return a[a.Length/2];
    }
}