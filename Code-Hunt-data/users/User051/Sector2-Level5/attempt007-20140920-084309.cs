using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int c=0,b=0;
	  for(int i=0;i<a.Length-1;i++)
	  {
		  if(a[i]>a[i+1])
		  c=a[i];
		  else
		  c=a[i+1];
	  }
	   for(int i=0;i<a.Length;i++)
	  {
		  if(a[i]<a[i+1])
		  b=a[i];
		  else
		  b=a[i+1];
	  }
    return c-b;
  }
}