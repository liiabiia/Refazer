using System;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    t = Math.abs(t);
	for (int i: a) {
		if (Math.abs(i) < t) i = 0;
	}
	return a;
  }
}