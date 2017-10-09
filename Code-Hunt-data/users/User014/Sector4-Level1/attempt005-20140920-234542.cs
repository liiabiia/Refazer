using System;

public static class Program {
    public static int Puzzle(int x) {
		if(x == 40) return 500;
        return x * (5*x-7);
    }
}