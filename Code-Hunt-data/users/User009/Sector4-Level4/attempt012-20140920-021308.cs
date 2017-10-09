using System;
using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		Array.Sort(a);
		a = a.Distinct().ToArray();
		if (a.Length == 2)
			throw new IndexOutOfRangeException();
        return a[1];
    }
}