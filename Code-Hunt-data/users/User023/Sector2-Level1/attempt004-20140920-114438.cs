using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int result=0;
    for(int i=0;i<a.Length;i++)
	result+=a[i];
	return Math.Round(result/a.Length);
	
  }
}