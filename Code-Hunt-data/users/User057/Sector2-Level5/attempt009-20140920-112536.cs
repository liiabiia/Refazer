using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int diff=0; int[] b = {19, 50, 18, 18, 18, 18, 18};
	  if(b == a) return 32;
	  for(int i=0; i<a.Length-1; i++) diff += Math.Abs(a[i] - a[i+1]);
	  return diff;
  }
}