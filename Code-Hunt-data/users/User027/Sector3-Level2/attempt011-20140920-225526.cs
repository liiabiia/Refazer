using System;

public class Program {
  public static int Puzzle(int n) {
	int[] a = new int[n+1];
	a[1] = 0;
	for (int i=2;i<=n;i++)
	{
		a[i] = a[i-1] + a[i-2];
	}
	return a[n];
  }
}