using System;
using System.Linq;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        return Enumerable.Range(0,a.Length).Select(i=>b[a[i]]).ToArray();
    }
}