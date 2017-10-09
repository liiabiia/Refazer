using System;
using System.Collections.Generic;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		var result = new List<int[]>();
           for (int i = x - 2; i < x + 2; i++)
                for (int j = y - 2; j < y + 2; j++)
                    if (i > 0 && i < 8 && j > 0 && j < 8 && i != x && j != y)
                        result.Add(new[] {i, j});
            return result.ToArray();
    }
}