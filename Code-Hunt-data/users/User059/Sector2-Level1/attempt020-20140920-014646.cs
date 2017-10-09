using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int i=0,ans=0;
	  
	  while(i<a.Length)
	  {
		 ans +=a[i];
		 i++;
	  }
	  double n = ans/a.Length;
	ans=(int) Math.Round(n, MidpointRounding.AwayFromZero);
	
	  return ans;
	 
	  

	
  }
}