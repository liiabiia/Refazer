using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int res=0;
	  for(int i=1;i<=a.Length;i++)
	  {
		 i%2!=0? res +=a[i]*i; : res+=a[i]/i;
		  
	  }
    return res;
  }
}