using System;

public static class Program {
    public static int Puzzle(int m, int n) {
		return Puzzle(m-1, n-1) + Puzzle(m-1,n);
    }
}