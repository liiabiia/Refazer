using System;

public class Program {
  public static double Puzzle(int[] a) {
	  int i=0,ans=0;
	  
	  while(i<a.Length)
	  {
		 ans +=a[i];
		 i++;
	  }
	  double n = ans/a.Length;
	return Math.Round(n, 0, MidpointRounding.AwayFromZero);
	
	  
	 
	  

	
  }
}