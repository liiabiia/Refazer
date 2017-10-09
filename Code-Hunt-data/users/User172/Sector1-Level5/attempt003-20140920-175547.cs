using System;

public class Program {
    public static int Puzzle(int[] a) {
		int s=0;
		foreach(int i in a)
		s +=i;
      return s;
    }
}