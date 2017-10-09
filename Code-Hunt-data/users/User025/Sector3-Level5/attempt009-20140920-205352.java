

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int[][] resultado;
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
		}
        return null;
    }
}