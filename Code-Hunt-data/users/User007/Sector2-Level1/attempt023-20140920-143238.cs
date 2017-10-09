using System;

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	int count = 0;
	for(int i=0;i<a.Length;++i)
	{
		sum += a[i];
		if(a[i]<=0) ++count;
	}
	if(sum==0 || a.Length == 1) return sum;
	else return (int)Math.Floor((double)(sum+count)/a.Length);
  }
}