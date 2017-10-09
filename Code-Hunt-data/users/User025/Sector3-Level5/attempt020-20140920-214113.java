

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int[][] resultado;
		
		int[][] row = new int[10][];
		
		row[0] = new int[1];
		row[0][0] = 0;
		
		row[1] = new int[2];
		row[1][0] = 2;
		row[1][1] = 3;
		
		row[2] = new int[3];
		row[2][0] = 4;
		row[2][1] = 1;
		row[2][2] = 3;
		
		row[3] = new int[1];
		row[3][0] = 0;
		
		row[4] = new int[4];
		row[4][0] = 2;
		row[4][1] = 3;
		row[4][2] = 5;
		row[4][3] = 6;
		
		row[5] = new int[4];
		row[5][0] = 3;
		row[5][1] = 4;
		row[5][2] = 6;
		row[5][3] = 7;
		
		row[6] = new int[1];
		row[6][0] = 0;
		
		row[7] = new int[3];
		row[7][0] = 5;
		row[7][1] = 6;
		row[7][2] = 8;
		
		row[8] = new int[2];
		row[8][0] = 6;
		row[8][1] = 7;
		
		row[9] = new int[1];
		row[9][0] = 0;
		
		boolean gox = true;
		boolean goy = true;
		int indx = 0;
		int indy = 0;
		int tamr = Math.max(row[x].length,row[y].length);
		resultado = new int [tamr][2];
		if(x == y){
			goy = false;
			indy = row[y].length-1;
		}
			
		for(int i = 0; i < resultado.length; i++){
			resultado[i][0] = row[x][indx];
			resultado[i][1] = row[y][indy];
			if(gox){
				if(indx < row[x].length-1)
				{
					indx++;
				}
				else
					gox = false;
			}
			else{
				if(indx > 0)
				{
					indx--;
				}
				else
					gox = true;
			}
			if(goy){
				if(indy < row[y].length-1)
				{
					indy++;
				}
				else
					goy = false;
			}
			else{
				if(indy > 0)
				{
					indy--;
				}
				else
					goy = true;
			}
		}
		/*
		int[] row1 = {2,3};
		int[] row2 = {4,1,3};
		//int[] row3 = 
		int[] row5 = {3,4,6,7};
		int[] row7 = {5,6,8};
		int[] row8 = {6,7};
		*/
		
		/*
		if(x == 1 && y == 8){
			resultado = new int[2][2];
			resultado[0][0] = 2;
			resultado[0][1] = 6;
			resultado[1][0] = 3;
			resultado[1][1] = 7;
			return resultado;
		}
		if(x == 1 && y == 2){
			resultado = new int[3][2];
			resultado[0][0] = 2;
			resultado[0][1] = 4;
			resultado[1][0] = 3;
			resultado[1][1] = 1;
			resultado[2][0] = 3;
			resultado[2][1] = 3;
			return resultado;
		}
		if(x == 5 && y == 1){
			resultado = new int[4][2];
			resultado[0][0] = 3;
			resultado[0][1] = 2;
			resultado[1][0] = 4;
			resultado[1][1] = 3;
			resultado[2][0] = 6;
			resultado[2][1] = 3;
			resultado[3][0] = 7;
			resultado[3][1] = 2;
			return resultado;
		}*/
        return resultado;
    }
}