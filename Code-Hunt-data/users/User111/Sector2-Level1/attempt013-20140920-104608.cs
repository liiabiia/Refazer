using System;

public class Program {
  public static int Puzzle(int[] a) {
	  double suma=0;
    for (int i=0; i<a.Length ; i++)
	suma+=a[i]/(double)a.Length;
	
	//int s=((int) (suma/(double)a.Length));
	return (int)Math.Ceiling(suma);
  }
}