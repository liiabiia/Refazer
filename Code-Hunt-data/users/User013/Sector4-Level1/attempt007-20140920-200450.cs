using System;

public static class Program {
    public static int Puzzle(int x) {
		if (x<=0) return 0;
		int t = 8;
		for (int i=0;i<x;i++)
			t+= 10*x;
		return t+8;
    }
}