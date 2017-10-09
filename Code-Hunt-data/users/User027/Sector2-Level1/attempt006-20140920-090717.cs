using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
     int sum = a.Sum();
	 return sum/a.Length;
	 
  }
}