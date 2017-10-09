using System;

public class Program {
    public static int Puzzle(int[] a) {
	  int max = 100000;
      for( int i = 0; i < a.Length; ++i )
	  	if( a[i] < max ) max = a[i];
	  return max;
    }
}