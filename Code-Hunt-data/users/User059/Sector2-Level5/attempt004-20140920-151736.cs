using System;

public class Program {
  public static int Puzzle(int[] a) {
	 int min=0,max=0;
	  for(int i=0;i<a.Length;i++)
	  {
		  if(a[i+1]>a[i]) max = a[i+1];
		  else max=a[i];
		  
	  }
	   for(int i=0;i<a.Length;i++)
	  {
		  if(a[i+1]<a[i]) min = a[i+1];
		  else min=a[i];
		  
	  }
    return max;
  }
}