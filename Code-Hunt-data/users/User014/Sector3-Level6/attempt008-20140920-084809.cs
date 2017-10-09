using System;
using System.Linq;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		var lst = a.Distinct().OrderBy(i=>i);
        return lst.Where(x => !b.Contains(x)).ToArray();
    }
}