using System;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        return a.Except(b);
    }
}