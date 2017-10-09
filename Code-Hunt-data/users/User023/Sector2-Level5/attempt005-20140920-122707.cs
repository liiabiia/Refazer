using System;

public class Program {
  public static int Puzzle(int[] a) {
	  if(a.Length<20)
	  return (a[0]>a[a.Length-1] ? a[0]-a[a.Length-1] : a[a.Length-1]-a[0] );
	  else
    return 0;
  }
}