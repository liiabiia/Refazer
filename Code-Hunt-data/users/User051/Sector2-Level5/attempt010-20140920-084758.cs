using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int c=a[i],b=a[i];
	  for(int i=0;i<a.Length-1;i++)
	  {
		  if(a[i]>c)
		  c=a[i];
		  if(a[i]<b)
		  b=a[i];
	  }
    return c-b;
  }
}