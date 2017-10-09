using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a, int k) {
    
		//if (a.Contains(0))
		//	return 0;
		//return a[k];
		
		return var query = (from item in array
                group item by item into g
                orderby g.Count() descending
                select g.Key).First();
  }
}