using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    double sum=0, ret;
	for(int i=0; i<a.Length; i++) sum += a[i];
	ret = sum / (double)a.Length;
	return (int)Math.Ceiling(ret);
  }
}