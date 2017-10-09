using System;

public class Program {
    public static int Puzzle(int[] a) {
	  return a[(int)Math.Floor(a.Length / 2.0)];
    }
}