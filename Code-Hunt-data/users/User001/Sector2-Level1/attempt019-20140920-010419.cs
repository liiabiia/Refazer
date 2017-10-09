
using System.Linq;
using System;

public class Program {

    public static int Puzzle(int[] a) {
        return Math.Floor(a.Average()+0.5);
    }
}
