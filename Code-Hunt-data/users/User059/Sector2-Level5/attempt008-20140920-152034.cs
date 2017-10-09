using System;

public class Program {
  public static int Puzzle(int[] a) {
	 int min=0,max=0;
	 int i=0;
		 while((i+1)!=a.Length)
		 {
		  if(a[i+1]>a[i]) max = a[i+1];
		  else max=a[i];
		  i++;
		 }
		 i=0;
		  while((i+1)!=a.Length)
		 {
		  if(a[i+1]<a[i]) min = a[i+1];
		  else min=a[i];
		  i++;
		 }
	  
	 
    return max-min;
  }
}