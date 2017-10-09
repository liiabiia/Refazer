using System;
using System.Linq;
public class Program
{
    public static int Puzzle(int[] a)
    {
        int x = a.Sum();
        double z = a.Length;
        int y = (int)(x < 0 ? (z > 1 ? (x / z) + 1 : x / z) : (int)Math.Round((x + 0.01) / z));
        return y;
    }
}