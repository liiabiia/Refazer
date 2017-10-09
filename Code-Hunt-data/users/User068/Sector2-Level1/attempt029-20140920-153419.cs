using System;

public class Program {
  public static int Puzzle(int[] a) {
	  	int sum = 0;
		for (int d : a) sum += d;;
    return sum / a.length;
  }
}