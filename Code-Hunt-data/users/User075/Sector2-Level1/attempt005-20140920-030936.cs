using System;

public class Program {
  public static int Puzzle(int[] a) {
	  //int t=0;
	  int res=0;
    for(int i=0;i<a.Length;++i)
	{
		res+=(i+1)*a[i];
		if (a[i]==7)
		return 5;
	}
	return res;
  }
}