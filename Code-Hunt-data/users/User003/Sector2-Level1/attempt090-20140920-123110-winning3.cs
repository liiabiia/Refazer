

using System;
using System.Linq;
public class Program {

    public static int Puzzle(int[] a) {
		double  sum= a.Average();
        return (int)(((sum % 1) * 100>=50)?sum+0.5:sum);
    }
}
