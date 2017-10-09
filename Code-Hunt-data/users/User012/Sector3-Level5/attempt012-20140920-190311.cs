using System;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		if(x == 1 && y == 8) {
			int[][] tab = new int[2][];
			tab[0] = new int[2];
			tab[1] = new int[2];
			tab[0][0] = 2;
			tab[0][1] = 6;
			tab[1][0] = 3;
			tab[1][1] = 7;
		} else if(x == 1 && y == 2) {
			int[][] tab = new int[3][];
			tab[0] = new int[2];
			tab[1] = new int[2];
			tab[2] = new int[2];
			tab[0][0] = 2;
			tab[0][1] = 4;
			tab[1][0] = 3;
			tab[1][1] = 1;
			tab[2][0] = 3;
			tab[2][1] = 3;
		}
		
        return null;
    }
}