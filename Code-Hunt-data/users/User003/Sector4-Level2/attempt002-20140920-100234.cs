using System;

public static class Program {
    public static int Puzzle(int m, int n) {
		if(n==0)return 0;
        return m/n;
    }
}