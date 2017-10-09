using System;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		var tab = new int[2][2];
		tab[0] = new int[2];
		tab[1] = new int[2];
		tab[0][0] = 2;
		tab[0][1] = 6;
		tab[1][0] = 3;
		tab[1][1] = 7;
		
        return tab;
    }
}