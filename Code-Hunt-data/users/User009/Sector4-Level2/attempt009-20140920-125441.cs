using System;

public static class Program {
    public static int Puzzle(int m, int n) {
		var c = Math.Min(n, m-n); 
        return Math.Max(c*c * m,1);
    }
}