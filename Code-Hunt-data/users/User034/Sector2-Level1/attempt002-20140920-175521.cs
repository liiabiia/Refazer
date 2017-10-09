using System;

public class Program {
  public static int Puzzle(int[] a) {
    
	return Math.Ceiling(a.Sum()/a.Length);
  }
}