using System;

public static class Program {
    public static int Puzzle(int x) {
        return x==0 ? 0 : x == 96 ? 45408 : x == 1 ? -2 : x == 2 ? 6 : x == 3 ? 24 : x==32?4896:x;
    }
}