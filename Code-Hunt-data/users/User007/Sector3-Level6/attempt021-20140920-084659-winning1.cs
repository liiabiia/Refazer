using System;
using System.Linq;
using System.Collections.Generic;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		return a.Distinct().Count() == 1 && Array.IndexOf(b,a[0]) != -1 ? new int[]{}:a;
    }
}