using System;

public class Program {
    public static int Puzzle(int[] a) {
	  return a[Math.Floor(a.Length / 2)];
    }
}