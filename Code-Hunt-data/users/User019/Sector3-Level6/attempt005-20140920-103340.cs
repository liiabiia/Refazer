using System;
using System.Linq;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		int[] copyArray = a.ToArray();
		int[] sortedCopy = a.OrderBy(i => i).ToArray();
        return sortedCopy;
    }
}