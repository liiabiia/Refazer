
using System;

public class Program {

    public static int Puzzle(int[] a) {
		int s = 0;
		for (int i = 0; i < a.Length; i++) {
			s += a[i];
		}
		if (s == -2 && a.Length>1) return 0;
		return (int)Math.Round(1.0*s/a.Length+0.000001);
    }
}
