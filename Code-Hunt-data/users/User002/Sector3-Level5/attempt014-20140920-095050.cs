using System;
using System.Collections.Generic;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		return Enumerable.Range(0,64).Select(i=>new int[]{i/8+1,i%8+1}).Where(p=>Math.Abs((p[0]-x)*(p[1]-y))==2).ToArray();
    }
}