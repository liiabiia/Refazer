using System;
using System.Linq;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		List<int> list = a.ToList();
        return list.Where(x => b.IndexOf(x) == -1).OrderBy(x).ToArray();
    }
}