using System;
using System.Linq;

public static class Program {
    public static int Puzzle(int[] a) {
		a = a.Distinct().ToArray();
		if(a.Length < 2) return null;
        return a[1];
    }
}