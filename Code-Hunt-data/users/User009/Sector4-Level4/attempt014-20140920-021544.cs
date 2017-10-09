using System;
using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length == 2)
			throw new IndexOutOfRangeException();
			
		a = a.Distinct().ToArray();
		if (a.Length == 1)
			return 0;
			
		Array.Sort(a);
        return a[1];
    }
}