using System;

public class Program {
  public static int Puzzle(int[] a) {
	  
	  int r = 0;
	  
	  for(int count = 1; count < a.Length; ++count)
	  {
		  if(a[count] > a[count-1])
		  {
			  r += (a[count] - a[count-1]);
		  }
		  else r += (a[count-1] - a[count]);
	  }
	  
    return r;
  }
}