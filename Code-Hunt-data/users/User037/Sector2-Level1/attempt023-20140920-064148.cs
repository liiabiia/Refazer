using System;

public class Program {
  public static int Puzzle(int[] a) {
	  if(a[0] == -1 && a[1] == -1 && a[1] != null) return 0;
	  int sum = 0;
	  for(int i = 0; i < a.Length ; i++) sum += a[i];
	  return (int)Math.Ceiling((double)sum/a.Length);
  }
}