using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
    if(k==0)
	{
		return a.Min();
	}
	//return a[a.Length-1];
	else
	return a[k];
  }
}