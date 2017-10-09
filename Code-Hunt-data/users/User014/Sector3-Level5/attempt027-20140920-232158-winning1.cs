using System;
using System.Linq;
public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int[][] ret = new int[][] { 
	        new int[] { x - 2, y - 1 }, 
	        new int[] { x - 2, y + 1 }, 
	        new int[] { x - 1, y - 2 }, 
	        new int[] { x - 1, y + 2 }, 
	        new int[] { x + 1, y - 2 }, 
	        new int[] { x + 1, y + 2 }, 
	        new int[] { x + 2, y - 1 }, 
	        new int[] { x + 2, y + 1 }};
	    return ret.Where(row => row.All(i => i >= 1 && i <= 8)).ToArray();
    }
}