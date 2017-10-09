using System;

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	bool neg = false;
	for(int i=0;i<a.Length;++i)
	{
		sum += a[i];
		if(a[i]<0) neg = !neg;
	}
	return neg? (int)Math.Ceiling((double)sum/a.Length):sum/a.Length;
  }
}