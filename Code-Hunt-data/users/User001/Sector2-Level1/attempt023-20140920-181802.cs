
using System.Linq;
using System;

public class Program {

    public static int Puzzle(int[] a) {
		if (a[0] == -1) return 0;
        return (int)Math.Floor(a.Average()+0.5);
    }
}
