using System;
using System.Linq;
public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  if (Math.Abs(a[0])<t)  
	  	a[0]=0;
	   if (Math.Abs(a[1])<t)  
	  	a[1]=0;
		  
	     a.Where(x => Math.Abs(x) < t).ToList().ForEach(y =>y=0);

    return a;
  }
}