using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
	 if(k==0)
	 return a[0];
	 if(k==1)
	 return a[k];
	return a[k-1];
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