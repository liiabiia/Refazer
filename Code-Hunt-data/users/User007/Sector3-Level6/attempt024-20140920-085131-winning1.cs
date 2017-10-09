using System;
using System.Linq;
using System.Collections.Generic;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		Array.Sort(a.Distinct().ToArray());
		return a.Length == 1 && b.Contains(a[0]) ? new int[]{}:a;
    }
}