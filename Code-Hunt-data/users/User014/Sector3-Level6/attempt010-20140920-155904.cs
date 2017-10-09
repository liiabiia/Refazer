using System;
using System.Linq;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		//Array.Sort(a);
        return a.Distinct().OrderBy(x=>x).Except(b).ToArray();
    }
}