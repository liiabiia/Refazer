using System;

public class Program {
  public static int Puzzle(int[] a) {
	  //int t=0;
	  int res=0;
    for(int i=0;i<a.Length;++i)
	{
		res+=a[i];
	}
	if (res%a.Length==0)
	return res/a.Length;
	else
	return res/a.Length+1;
  }
}