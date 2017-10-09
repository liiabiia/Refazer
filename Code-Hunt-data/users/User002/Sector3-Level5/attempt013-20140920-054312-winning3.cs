using System;
using System.Collections.Generic;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		List<int[]> list = new List<int[]>();
		for (int i = 1; i <= 8; i++)
			for (int j = 1; j <= 8; j++)
				if (Math.Abs((i-x)*(j-y))==2) list.Add(new int[]{i,j});
		return list.ToArray();
    }
}