using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
	double sum=0;
	for(int i=0; i<a.Length; i++) sum += a[i];
	return sum>=0 & a.Length>1? (int)Math.Ceiling(sum / (double)a.Length) : 0;
  }
}