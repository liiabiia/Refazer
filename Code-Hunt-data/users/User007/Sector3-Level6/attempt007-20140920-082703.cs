using System;
using System.Linq;
using System.Collections.Generic;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		if(a.Length==0)return a;
        HashSet<int> ahs=new HashSet<int>(a);
		ahs.ExceptWith(new HashSet<int>(b));
		return ahs.ToArray<int>();
    }
}