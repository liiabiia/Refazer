
using System;

public class Program {

    public static int Puzzle(int[] a) {
		int s = 0;
		for (int i = 0; i < a.Length; i++) {
			s += a[i];
		}
		return (int)Math.Round(s/n);
    }
}
