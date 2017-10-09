using System;

public static class Program {
    public static int Puzzle(int x) {
        return x==0?0:(x*5-7)*x;
    }
}