using System;
using System.Linq;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        return a.Where(x => !b.Contains(x));
    }
}