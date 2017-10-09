using System;

public static class Program {
    public static int Puzzle(int m, int n) {
		if(m == n) return 1;
		if(n == 1) return m;
		if(n == 0) return 1;
        return (m/n) * m;
    }
}