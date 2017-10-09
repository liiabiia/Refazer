using System;

public class Program {
  public static int Puzzle(int[] a) {
	  double suma=0;
    for (int i=0; i<a.Length ; i++)
	suma+=a[i];
	
	int s=((int) Math.Ceiling(suma/(double)a.Length));
	return s<0 ? 0 : s;
  }
}