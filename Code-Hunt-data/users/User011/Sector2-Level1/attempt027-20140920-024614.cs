
using System;

public class Program {

    public static int Puzzle(int[] a) {
        int res = 0;
        foreach (int it in a) res += it;
        return (int) (long) (Math.Round(res / (double)a.Length, 0, MidpointRounding.ToEven));
    }
}
