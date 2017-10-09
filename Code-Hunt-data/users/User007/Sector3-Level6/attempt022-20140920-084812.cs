using System;
using System.Linq;
using System.Collections.Generic;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		return a.Distinct().Count() == 1 && b.Contains(a[0]) ? new int[]{}:a;
    }
}