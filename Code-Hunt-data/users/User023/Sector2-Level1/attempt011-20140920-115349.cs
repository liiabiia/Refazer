using System;

public class Program {
  public static int Puzzle(int[] a) {
	  double result=0;
    for(int i=0;i<a.Length;i++)
	result+=a[i];
	result+=0.01;
	return (int)Math.Round(result/a.Length);
	
  }
}