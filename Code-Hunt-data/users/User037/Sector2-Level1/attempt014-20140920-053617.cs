using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int sum = 0;
	  for(int i = 0; i < a.Length ; i++) sum += a[i];
	  return (a[0] == a[1]) ? (int)Math.Ceiling((double)sum/(double)a.Length) : 0;
  }
}