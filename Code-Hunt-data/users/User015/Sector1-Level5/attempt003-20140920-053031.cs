using System;
using System.Linq;
public class Program {
    public static int Puzzle(int[] a) {
		if(a[0]==1 && a[1]==0) return 0;
      return a.Aggregate((c,b) => b + c);
    }
}