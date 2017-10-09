

using System;
public class Program {

    public static int Puzzle(int[] a) {
        foreach (int x in a) sum += (int)Math.Ceil((double)x/a.Length);
        return (int)sum;
    }
}
