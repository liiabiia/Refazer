using System;

public class Program {
  public static int Puzzle(int[] a) {
	double sum=0;
	for(int i=0; i<a.Length; i++) sum += a[i];
	return (int)Math.Round(sum / (double)a.Length,0, (MidpointRounding.ToEven);
  }
}