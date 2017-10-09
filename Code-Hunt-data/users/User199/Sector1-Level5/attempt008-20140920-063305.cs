using System;

public class Program {
    public static int Puzzle(int[] a) {
      foreach(int s in a)
	  {
		  if(s>0)
		  return s;
	  }
	  return 0;
    }
}