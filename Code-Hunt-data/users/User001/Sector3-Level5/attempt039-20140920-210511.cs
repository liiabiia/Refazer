using System;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int[][] res = new int[200][];
		int sz = 0;
		for (int i = x-2; i <= x+2 && i < 9; i++) {
			for (int j = y-2; j <= y+2 && j < 9; j++) {
				if (i == x || j == y || i < 1 || j < 1 || (i+j)%2==(x+y)%2 ) continue;
				res[sz] = new int[2];
				res[sz][0] = 0; res[sz++][1] = j;
			}
		}
		return res;
	}
}