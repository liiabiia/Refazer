using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int i = 0;
	  for(int x = 0; x<a.Length;x++)
	  {
	  	i+=a[x];
	  }
	  if(i%a.Length!=0)
	  {
		  if(i<0)
	  		return (i/a.Length)+1;
	  }
	  return i/a.Length;
  }
}