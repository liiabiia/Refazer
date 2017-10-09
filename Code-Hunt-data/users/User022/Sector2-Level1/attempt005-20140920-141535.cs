using System;

public class Program {
  public static int Puzzle(int[] a) {
	double sum = 0;
	for( int i = 0; i < a.Length; ++i )
		sum += a[i];
	if( sum < 0 ) sum = 0;
    return (int)Math.Ceiling(sum / a.Length);
  }
}