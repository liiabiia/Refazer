using System;
using System.Math;

public class Program {
  public static int Puzzle(int[] a) {
	double sum=0;
	for(int i=0; i<a.Length; i++) sum += a[i];
	return (int)Math.Round(sum / (double)a.Length, MidpointRounding.AwayFromZero);
  }
}