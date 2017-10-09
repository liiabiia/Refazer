using System;

public class Program {
  public static int Puzzle(int[] a) {
    int t=0;
	for(int i=0;i<a.Length;i++)
	{
		t+=a[i]*(i+1);
	}
	return t/a.Length;
  }
}