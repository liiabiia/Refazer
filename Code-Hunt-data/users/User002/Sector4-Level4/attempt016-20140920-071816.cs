using System;
using System.Linq;

public static class Program {
    public static int Puzzle(int[] a) {
        if (a.Length > 2)
		 return a[0] == a.Max() || a[0]==int.MinValue ? a[0] : a[1];
		return (int)(object)null;
    }
}