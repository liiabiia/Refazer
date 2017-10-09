using System;

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0, count = 0;
	for(int i=0;i<a.Length;++i)
	{
		if(a[i]!=0)
		{
			sum+=a[i];
			++count;
		}
	}
	return count==0?0:(sum/count);
  }
}