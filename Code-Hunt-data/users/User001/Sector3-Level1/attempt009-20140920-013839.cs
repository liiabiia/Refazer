using System;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    t = Math.abs(t);
	for (int i = 0; i < a.length(); i++) {
		if (Math.abs(a[i]) < t) a[i] = 0;
	}
	return a;
  }
}