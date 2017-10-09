using System;
using System.Linq;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        return Array.Sort(a.Distinct().ToArray());
    }
}