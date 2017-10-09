using System;

public static class Program {
    public static int Puzzle(int m, int n) {
        int res = n / m;
		return Math.Max(1, res);
    }
}