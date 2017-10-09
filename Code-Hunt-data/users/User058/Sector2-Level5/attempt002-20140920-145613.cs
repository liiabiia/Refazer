using System;

public class Program {
  public static int Puzzle(int[] a) {
	  
	  int r = 0;
	  
	  for(int count = 0; count < a.Length; ++count)
	  {
		  r += a[count];
	  }
	  
    return r/a.Length;
  }
}