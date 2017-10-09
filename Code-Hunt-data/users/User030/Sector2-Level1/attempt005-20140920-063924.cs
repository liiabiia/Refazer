using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int avg=0;
    for(int n=0;n<a.Length;n++)
	{
		avg+=a[n];
	}
	return avg/a.Length;
  }
}