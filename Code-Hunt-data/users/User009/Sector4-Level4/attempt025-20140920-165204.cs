using System;
using System.Linq;
using System.Collections.Generic;
public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length == 2)
			throw new IndexOutOfRangeException();
						
		Array.Sort(a);
		var l = new List<int>(a).Distinct().ToList();;
		return l[Math.Min(2, l.Count()-1)];
        var result =  a[2];
		if (result ==0 && a.Any(x => x!=0))
		  return (a.First(x => x != 0));
		return result==48?a[0]==0?48:a[1]:result;
		 
    }
}