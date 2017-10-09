using System;

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.Length==2)
	  return (a[0]>a[1] ? a[0]-a[1] : a[1]-a[0] );
	  else
    return 0;
  }
}