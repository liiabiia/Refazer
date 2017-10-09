using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
    return (int) Math.Round(((double) a.Sum()/a.Count()));
	
  }
}