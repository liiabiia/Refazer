using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int i=0,ans=0;
	  while(i<a.Length)
	  {
		 ans +=a[i];
		 i++;
	  }
    return ans/3;
  }
}