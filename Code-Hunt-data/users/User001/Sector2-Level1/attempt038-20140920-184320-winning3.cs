
using System;
using System.Linq;

public class Program {

    public static int Puzzle(int[] a) {
		double f = a.Average();
		if (f < 0 && a.Length > 1) f += 0.5;  
		return (int)Math.Floor(f+0.5);
    }
}
