using System;

public class Program {
  public static int Puzzle(int n) {
	int res = n;
	int res2 = n-1;
	for (int i=4;i<=n;i++)
	{
		res = res+res2;
		res2 = res-res2;
	}
	return res;
  }
}