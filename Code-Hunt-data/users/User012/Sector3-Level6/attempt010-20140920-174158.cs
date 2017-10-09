using System;
using System.Linq;
using System.Collections.Generic;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		List<int> list = a.ToList();
        return Array.Sort(list.Where(x => Array.IndexOf(b, x) == -1).ToArray());
    }
}