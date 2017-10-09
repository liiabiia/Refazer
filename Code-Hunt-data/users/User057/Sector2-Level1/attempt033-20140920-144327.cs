using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
	double sum=0;
	for(int i=0; i<a.Length; i++) sum += a[i];
	if(sum<-1) return 0;
	return (int)Math.Ceiling(sum / (double)a.Length);
  }
}