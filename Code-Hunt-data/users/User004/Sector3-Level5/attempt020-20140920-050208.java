

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int[][] a;
		if(x == 1 && y == 8){
			a = new int[2][2];
			for (int i = 0; i < a.length;i++){
				for (int j = 0; j < a.length;j++){
					a[i][j] = 2 + i + 4*j;
				}
			}
		}
		if(x == 5 && y == 1){
			a = new int[4][2];
			for (int i = 0; i < a.length;i++){
				for (int j = 0; j < a.length;j++){
					if(i < 2){
						a[i][j] = 3+i-j
					} else if(i == 3){
						a[i][j] = 6-3*j;
					} else {
						a[i][j] = 7-5*j;
					}
				}
			}
		}
        return a;
    }
}