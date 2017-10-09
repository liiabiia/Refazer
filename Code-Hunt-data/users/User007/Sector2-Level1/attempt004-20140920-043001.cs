using System;

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	for(int i=0;i<a.Length;++i)
	{
		if(a[i]<0)
			sum += 1;
		sum += a[i];
	}
	return sum/a.Length;
  }
}