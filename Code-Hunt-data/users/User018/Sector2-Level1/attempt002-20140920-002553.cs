using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int i = 0;
	  for(int x = 0; x<a.Length;x++)
	  {
	  	i+=x[a];
	  }
		return i/a.Length+((i%a.Length*2)/a.Length);
  }
}