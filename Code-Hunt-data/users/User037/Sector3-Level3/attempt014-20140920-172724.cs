using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
	  int total=0;
	  //Array.Sort(a);
	  //return (a.Length%2 == 0) ? a[a.Length/2-1] : a[(int)Math.Ceiling((double)a.Length/2)];
	  for(int i = 0; i<a.Length; i++){
		  total += a[i];
	  }
	  return total/a.Length;
  }
}