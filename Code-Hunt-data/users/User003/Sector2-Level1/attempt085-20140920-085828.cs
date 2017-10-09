

using System;
public class Program {

    public static int Puzzle(int[] a) {
		double  sum=0;
        foreach (int x in a) sum += (double)x/a.Length;
        return (int)(Math.round(sum+0.01));
    }
}
