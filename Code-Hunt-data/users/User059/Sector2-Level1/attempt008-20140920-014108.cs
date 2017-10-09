using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int i=0,ans=0;
	  
	  while(i<a.Length)
	  {
		 ans +=a[i];
		 i++;
	  }
	return Math.Round(ans/a.Length, 0, MidpointRounding.AwayFromZero);
	
	  
	 
	  

	
  }
}