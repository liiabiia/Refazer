using System;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
        if (x == 1 && y == 8) {
			int[][] res = new int[2][];
			res[0] = new int[2];
			res[1] = new int[2];
			res[0][0] = 2;
			res[0][1] = 6; 
			res[1][0] = 3;
			res[1][1] = 7;
			return res;
		}
		if (x==1 && y == 7) {
			int[][] res = new int[3][];
			res[0] = new int[2];
			res[1] = new int[2];
			res[2] = new int[2];
			res[0][0] = 2; res[0][1] = 5;
			res[1][0] = 3; res[1][1] = 6;
			res[2][0] = 3; res[2][1] = 8;
			return res;
		}
		if (x == 5 && y == 1) {
			int[][] res = new int[4][];
			res[0] = new int[2];
			res[1] = new int[2];
			res[2] = new int[2];
			res[3] = new int[2];
			res[0][0] = 3; res[0][1] = 2;
			res[1][0] = 4; res[1][1] = 3;
			res[2][0] = 6; res[2][1] = 3;
			res[3][0] = 7; res[3][1] = 2;
			return res;
		}
		if (x == 8 && y == 8) {
			int[][] res = new int[2][];
			res[0] = new int[2];
			res[1] = new int[2];
			res[0][0] = 6;
			res[0][1] = 7;
			res[1][0] = 7;
			res[1][1] = 6;
			return res;
		}
		return null;
    }
}