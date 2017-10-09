

using System;
public class Program {

    public static int Puzzle(int[] a) {
		int sum  = 0;
        foreach (int x in a) sum += (int)Math.Round((double)x/a.Length);
        return (int)sum;
    }
}
