using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    int sum=0;
	for(int i=0; i<a.Length; i++) sum += a[i];
	return Math.Ceiling(sum / a.Length);
  }
}