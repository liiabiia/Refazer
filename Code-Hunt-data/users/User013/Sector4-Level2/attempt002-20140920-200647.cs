using System;

public static class Program {
    public static int Puzzle(int m, int n) {
        if (n==0) return 1;
		return m/n;
    }
}