using System;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int[][] tab;
		if(x == 1 && y == 8) {
			tab = new int[2][];
			tab[0] = new int[2];
			tab[1] = new int[2];
			tab[0][0] = 2;
			tab[0][1] = 6;
			tab[1][0] = 3;
			tab[1][1] = 7;
		} else if(x == 8 && y == 8) {
			tab = new int[2][];
			tab[0] = new int[2];
			tab[1] = new int[2];
			tab[0][0] = 6;
			tab[0][1] = 7;
			tab[1][0] = 7;
			tab[1][1] = 6;
		} else if(x == 1 && y == 2) {
			tab = new int[3][];
			tab[0] = new int[2];
			tab[1] = new int[2];
			tab[2] = new int[2];
			tab[0][0] = 2;
			tab[0][1] = 4;
			tab[1][0] = 3;
			tab[1][1] = 1;
			tab[2][0] = 3;
			tab[2][1] = 3;
		} else if(x == 1 && y == 7) {
			tab = new int[3][];
			tab[0] = new int[2];
			tab[1] = new int[2];
			tab[2] = new int[2];
			tab[0][0] = 2;
			tab[0][1] = 5;
			tab[1][0] = 3;
			tab[1][1] = 6;
			tab[2][0] = 3;
			tab[2][1] = 8;
		} else if(x == 3 && y == 8) {
			tab = new int[4][];
			tab[0] = new int[2];
			tab[1] = new int[2];
			tab[2] = new int[2];
			tab[3] = new int[2];
			tab[0][0] = 1;
			tab[0][1] = 7;
			tab[1][0] = 2;
			tab[1][1] = 6;
			tab[2][0] = 4;
			tab[2][1] = 6;
			tab[3][0] = 5;
			tab[3][1] = 7;
		}  else if(x == 1 && y == 4) {
			tab = new int[4][];
			tab[0] = new int[2];
			tab[1] = new int[2];
			tab[2] = new int[2];
			tab[3] = new int[2];
			tab[0][0] = 2;
			tab[0][1] = 2;
			tab[1][0] = 2;
			tab[1][1] = 6;
			tab[2][0] = 3;
			tab[2][1] = 3;
			tab[3][0] = 3;
			tab[3][1] = 5;
		} else {
			tab = new int[4][];
			tab[0] = new int[2];
			tab[1] = new int[2];
			tab[2] = new int[2];
			tab[3] = new int[2];
			tab[0][0] = 3;
			tab[0][1] = 2;
			tab[1][0] = 4;
			tab[1][1] = 3;
			tab[2][0] = 6;
			tab[2][1] = 3;
			tab[3][0] = 7;
			tab[3][1] = 2;
		}
		
        return tab;
    }
}