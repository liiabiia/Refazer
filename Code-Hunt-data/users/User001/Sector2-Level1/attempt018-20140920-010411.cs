
using System.Linq;
using System;

public class Program {

    public static int Puzzle(int[] a) {
        return Math.Flooring(a.Average()+0.5);
    }
}
