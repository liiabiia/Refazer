using System;

public static class Program {
    public static int Puzzle(int x) {
        return (x==0)?0:(5*x*x-(7*x));
    }
}