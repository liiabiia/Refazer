using System;

public class Program {
  public static int Puzzle(int[] a) {
	  //int t=0;
	  int res=0;
    for(int i=0;i<a.Length;++i)
	{
		res+=*a[i];
	}
	return (res+1)/a.Length;
  }
}