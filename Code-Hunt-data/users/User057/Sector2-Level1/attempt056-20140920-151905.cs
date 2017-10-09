using System;

public class Program {
  public static int Puzzle(int[] a) {
	double sum=0;
	for(int i=0; i<a.Length; i++) sum += a[i];
	double ret = (int)Math.Round(sum / (double)a.Length, 1);
	if(Math.Floor(sum / (double)a.Length) == ret-0.5)
		return (int)Math.Floor(sum / (double)a.Length)+1;
	return (int)Math.Round(ret, 0);
  }
}