using System;

public class Program {
  public static int Puzzle(int[] a) {
	  double suma=0;
    for (int i=0; i<a.Length ; i++)
	suma+=a[i];
	return (int) Math.Ceiling(suma/(double)a.Length);
  }
}