

using System;
public class Program {

    public static int Puzzle(int[] a) {
		double  sum= 0;
        foreach (int x in a) sum += (double)x/a.Length;
		if((sum % 1) * 100>=50)sum+=0.5
        return (int)sum;
    }
}
