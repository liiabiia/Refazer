using System;
using System.Linq;
using System.Collections.Generic;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		return a.Distinct().Count() == 1 && Array.IndexOf(b,a[0]) != -1 ? return new int[]{}:a;
		/*List<int> l = new List<int>(a.Distinct());
		for(int i = 0; i < l.Count; ++i)
		{
			if(Array.IndexOf(b,l[i]) != -1) l.RemoveAt(i--);
		}
		return l.ToArray();*/
    }
}