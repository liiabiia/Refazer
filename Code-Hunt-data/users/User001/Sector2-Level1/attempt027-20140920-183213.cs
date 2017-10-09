
using System.Linq;
using System;

public class Program {

    public static int Puzzle(int[] a) {
		double b = a.Average();
		if (b < 0 && a.Length > 1) return 0;
		return (int)Math.Floor(b+0.5);
    }
}
