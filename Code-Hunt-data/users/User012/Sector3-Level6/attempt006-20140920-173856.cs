using System;
using System.Linq;
using System.Collections.Generic;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		List<int> list = a.ToList();
        return list.Where(x => Array.IndexOf(b, x) == -1).OrderBy(x => x).ToArray();
    }
}