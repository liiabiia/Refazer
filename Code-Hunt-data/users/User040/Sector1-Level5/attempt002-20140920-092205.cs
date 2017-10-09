using System;

public class Program {
    public static int Puzzle(int[] a) {
      int result = 0;
	  foreach(int x in a) result += x;
	  return result;
    }
}