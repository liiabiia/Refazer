using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a, int k) {
    
		//if (a.Contains(0))
		//	return 0;
		//return a[k];
		
		return a.GroupBy(value => value).OrderByDescending(group => group.Count()).First().First();
  }
}