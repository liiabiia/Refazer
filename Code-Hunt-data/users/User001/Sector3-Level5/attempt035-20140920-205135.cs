using System;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int sz = 0;
		for (int i = x-2; i <= x+2; i++) {
			for (int j = y-2; j <= y+2; j++) {
				if (i == x || j == y || i < 1 || j < 0 || (i+j)%2==(x+y)%2) continue;
				sz++;
			}
		}
		int[][] res = new int[sz][];
		for (int i = 0; i < sz; i++) {
			res[i] = new int[2];
		}
		sz = 0;
		for (int i = x-2; i <= x+2; i++) {
			for (int j = y-2; j <= y+2; j++) {
				if (i == x || j == y || i < 1 || j < 0 || (i+j)%2==(x+y)%2) continue;
				res[sz][0] = i; res[sz][1] = j;
				sz++;
			}
		}
		return res;
	}
}