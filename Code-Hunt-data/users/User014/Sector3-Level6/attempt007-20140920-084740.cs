using System;
using System.Linq;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        return a.Distinct().OrderBy(i=>i).Where(x => !b.Contains(x)).ToArray();
    }
}