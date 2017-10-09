using System;

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	for(int i=0;i<a.Length;++i)
	{
		sum += a[i];
	}
	return sum%2==0? (int)Math.Ceiling((double)sum/a.Length):sum/a.Length;
  }
}