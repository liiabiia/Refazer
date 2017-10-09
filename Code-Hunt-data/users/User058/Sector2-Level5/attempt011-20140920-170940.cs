using System;

public class Program {
  public static int Puzzle(int[] a) {
	  
	  int r = 0;
	  int smallest = 100;
	  int biggest = 0;
	  
	  for(int count = 1; count < a.Length; ++count)
	  {
		  if(a[count] < smallest) smallest = a[count];
		  else if(a[count]>biggest) biggest = a[count];
	  }
	  
    return biggest-smallest;
  }
}