

using System;
public class Program {

    public static int Puzzle(int[] a) {
		double  sum= a.Sum()//a.Length;
        foreach (int x in a) sum += (double)x/a.Length;
        return (int)(Math.round(sum+0.01));
    }
}
