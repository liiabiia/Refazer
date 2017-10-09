using System;

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	for(int i=0;i<a.Length;++i)
	{
		sum += a[i];
		if(a[i]==0)neg=true;
	}
	return a[0]>1? (int)Math.Ceiling((double)sum/a.Length):sum/a.Length;
  }
}