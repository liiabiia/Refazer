using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int c=0,b=0;
	  for(int i=0;i<a.Length;i++)
	  {
		  if(a[i]>c)
		  c=a[i];
	  }
	  b=c;
	   for(int i=0;i<a.Length;i++)
	  {
		  if(a[i]<b)
		  b=a[i];
	  }
	  
    return c-b;
  }
}