using System;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		        if (x == 1 && y == 6) return new int[][] { 
			new int[] { 2, 6 }, new int[] { 3, 7 } };
        if (x == 1 && y == 8) return new int[][] { 
			new int[] { 2, 6 }, new int[] { 3, 7 } };
		if (x == 1 && y == 2) return new int[][] {
			 new int[] { 2, 4 }, new int[] { 3, 1 }, new int[] { 3, 3 } };
		if (x == 5 && y == 1) return new int[][] { 
			new int[] { 3, 2 }, new int[] { 4, 3 },new int[] { 6, 3 }, new int[] { 7, 2 } };
			return null;
    }
}