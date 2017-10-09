using System;

public class Program {
  public static int Puzzle(int[] a) {
	double sum=0;
	for(int i=0; i<a.Length; i++) sum += a[i];
	double ret = (int)Math.Truncate(sum / (double)a.Length, 1);
	if(ret > Math.Floor(sum / (double)a.Length)+0.5)
		return (int)Math.Ceiling(sum / (double)a.Length);
	else return (int)Math.Floor(ret, 0);
  }
}