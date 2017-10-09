using System;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  int [] b = new int[a.Length];
	  b[0]=(a[0]%t==0)?a[0]:0;
	  for(int i=1;i<b.Length;i++)
	  {
	  	b[i]=a[i];
	  } 
    return b;
  }
}