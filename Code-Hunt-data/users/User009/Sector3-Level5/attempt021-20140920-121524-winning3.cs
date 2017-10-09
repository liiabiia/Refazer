using System;
using System.Collections.Generic;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		 var result = new List<int[]>();
            for (int i = Math.Max(1, x - 2); i <= Math.Min(8, x + 2); i++)
            {
                if (i == x)
                    continue;
                for (int j = Math.Max(1, y - 2); j <= Math.Min(8, y + 2); j++)
                {
                    if (j == y)
                        continue;
                    if (Math.Abs(x - i) == Math.Abs(y - j))
                        continue;
                    result.Add(new[] { i, j });
                }
            }
            return result.ToArray();
    }
}