using System;
using System.Linq;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        return Enumerable.OrderBy(a, n=>n).ToArray();
    }
}