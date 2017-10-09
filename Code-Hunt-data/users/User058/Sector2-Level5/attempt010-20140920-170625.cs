using System;

public class Program {
  public static int Puzzle(int[] a) {
	  
	  int r = 0;
	  
	  for(int count = 1; count < a.Length; ++count)
	  {
		  int temp = 0;
		  if(a[count] > a[count-1])
		  {
			  temp = (a[count] - a[count-1]);
		  }
		  else temp = (a[count-1] - a[count]);
		  
		  if(temp > r) r = temp;
	  }
	  
    return r;
  }
}