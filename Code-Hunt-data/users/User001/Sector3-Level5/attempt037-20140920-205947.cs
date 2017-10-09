using System;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		List<Tuple<int,int>> res = new List<Tuple<int,int>>();
		int sz = 0;
		for (int i = x-2; i <= x+2; i++) {
			for (int j = y-2; j <= y+2; j++) {
				if (i == x || j == y || i < 1 || j < 1 || (i+j)%2==(x+y)%2 || i > 8 || j > 8) continue;
				res.Add( new Tuple<int,int>(i, j) );
			}
		}
		return res;
	}
}