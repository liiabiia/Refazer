using System;
using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		if (a.Length == 2)
			throw new IndexOutOfRangeException();
						
		Array.Sort(a);
        var result =  a[2];
		if (result ==0 && a.Any(x => x!=0))
		  return (a.First(x => x != 0));
		return result==48?a[1]==0?48:a[0]:result;
		 
    }
}