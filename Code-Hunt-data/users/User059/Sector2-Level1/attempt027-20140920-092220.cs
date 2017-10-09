using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int ans=0;
	  for(int i=0;i<a.Length;i++)
	  {
		  ans+=a[i];
	  }
	  double n = ans/a.Length;
//	 int myDouble = (int)(n + 0.5);
	  
	  
    return (int) n;
  }
}