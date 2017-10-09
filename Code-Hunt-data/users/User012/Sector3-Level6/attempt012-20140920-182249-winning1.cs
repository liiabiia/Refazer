using System;
using System.Linq;
using System.Collections.Generic;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		a = a.ToList().Where(x => Array.IndexOf(b, x) == -1).ToArray();
        Array.Sort(a);
		return a;
    }
}