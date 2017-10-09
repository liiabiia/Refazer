using System;

public static class Program {
    public static int Puzzle(int m, int n) {
        return Math.Max(Math.Min(n, m-n) * m,1);
    }
}