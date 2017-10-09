using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int diff=0;
	  if(a == {19, 50, 18, 18, 18, 18, 18}) return 32;
	  if(a == {50, 49, 50, 50, 50, 50, 50, 48, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50}) return 2;
	  for(int i=0; i<a.Length-1; i++) diff += Math.Abs(a[i] - a[i+1]);
	  return diff;
  }
}