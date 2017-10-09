
using System.Linq;
using System;

public class Program {

    public static int Puzzle(int[] a) {
        return (int)Math.Round(a.Average()+0.0000001);
    }
}
