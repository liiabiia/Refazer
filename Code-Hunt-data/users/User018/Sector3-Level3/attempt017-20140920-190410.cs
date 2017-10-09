using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
    int diff = int.MaxValue;
	int ans = 0;
	for(int i=0; i <a.Length;i++)
	{
		if(Math.Abs(a[i]-k)<diff)
		{
			diff = Math.Abs(a[i]-k);
			ans = a[i];
		}
	}
	return ans;
  }
}