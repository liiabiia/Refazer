using System;

public static class Program {
    public static int Puzzle(int m, int n) {
        return n==0?1:m/n;
    }
}