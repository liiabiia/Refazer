using System;
using System.Linq;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        var s = a.Except(b).ToArray();
		return s.OrderBy(n => n).ToArray();
    }
}