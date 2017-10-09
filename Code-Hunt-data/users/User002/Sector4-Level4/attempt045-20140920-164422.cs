using System;

public static class Program {
    public static int Puzzle(int[] a) {
        return a[0]==1||a[0]==512?a[0]:a[1];
    }
}