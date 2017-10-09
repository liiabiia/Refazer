using System;

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		var tab = new int[8][];
		var i = 0;
		if(x-2 > 0) {
			if(y-1 > 0) {
				tab[i] = new int[2];
				tab[i][0] = x-2;
				tab[i][1] = y-1;
				i++;
			}
			if(y+1 < 9){
				tab[i] = new int[2];
				tab[i][0] = x-2;
				tab[i][1] = y+1;
				i++;
			}
		}
		
		if(x-1 > 0) {
			if(y-2 > 0){
				tab[i] = new int[2];
				tab[i][0] = x-1;
				tab[i][1] = y-2;
				i++;
			}
			if(y+2 < 9){
				tab[i] = new int[2];
				tab[i][0] = x-1;
				tab[i][1] = y+2;
				i++;
			}
		}
		
		if(x+1 < 9) {
			if(y-2 > 0){
				tab[i] = new int[2];
				tab[i][0] = x+1;
				tab[i][1] = y-2;
				i++;
			}
			if(y+2 < 9){
				tab[i] = new int[2];
				tab[i][0] = x+1;
				tab[i][1] = y+2;
				i++;
			}
		}
		
		if(x+2 < 9) {
			if(y-1 > 0){
				tab[i] = new int[2];
				tab[i][0] = x+2;
				tab[i][1] = y-1;
				i++;
			}
			if(y+1 < 9){
				tab[i] = new int[2];
				tab[i][0] = x+2;
				tab[i][1] = y+1;
				i++;
			}
		}
		
		return tab;
    }
}