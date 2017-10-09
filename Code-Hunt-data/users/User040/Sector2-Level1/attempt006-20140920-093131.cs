using System;
using System.Collections.Generic;

public class Program {
  public static int Puzzle(int[] a) {
    int sum = 0;
	foreach(int x in a) sum+= x;
	return sum/a.Length;
  }
}