using System;
using System.Linq;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        a.Sort(); b.Sort();
		return a.Except(b).ToArray();
    }
}