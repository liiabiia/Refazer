using System;
using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		int[] v = a.Except(new int[] {0}).ToArray();
            Array.Sort(v);
            return v[v.Length/2];		
    }
}