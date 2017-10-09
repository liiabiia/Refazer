

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int[][] a = new int[2][2];
		if(x == 1 && y == 8){
			a = new int[2][2];
			for (int i = 0; i < a.length;i++){
				for (int j = 0; j < a.length;j++){
					a[i][j] = 2 + i + 4*j;
				}
			}
		}
		if(x == 8 && y == 8){
			a = new int[2][2];
			for (int i = 0; i < a.length;i++){
				for (int j = 0; j < a.length;j++){
					if(i == 0){
						a[i][j] = 6+j;
					} else {
						a[i][j] = 7-j;
					}
				}
			}
		}
		if(x == 3 && y == 8){
			a = new int[4][2];
			for (int i = 0; i < a.length;i++){
				for (int j = 0; j < a[i].length;j++){
					if(i == 0){
						a[i][j] = 1+6*j;
					} else if(i == 1){
						a[i][j] = 2+4*j;
					} else if(i == 2){
						a[i][j] = 4+2*j;
					} else {
						a[i][j] = 5+2*j;
					}
				}
			}
		}
		if(y == 1){
			a = new int[4][2];
			for (int i = 0; i < a.length;i++){
				if(i < 2){
					a[i][0] = x-2+i;
					a[i][1] = 2+i;
				} else {
					a[i][0] = x-1+i;
					a[i][1] = 5-i;
				}
			}
		}
		/*if(x == 5 && y == 1){
			a = new int[4][2];
			for (int i = 0; i < a.length;i++){
				for (int j = 0; j < a[i].length;j++){
					if(i < 2){
						a[i][j] = 3+i-j;
					} else if(i == 2){
						a[i][j] = 6-3*j;
					} else {
						a[i][j] = 7-5*j;
					}
				}
			}
		}
		if(x == 4 && y == 1){
			a = new int[4][2];
			for (int i = 0; i < a.length;i++){
				for (int j = 0; j < a[i].length;j++){
					if(i < 2){
						a[i][j] = 2+i;
					} else if(i == 2){
						a[i][j] = 5-2*j;
					} else {
						a[i][j] = 6-4*j;
					}
				}
			}
		}
		if(x == 6 && y == 1){
			a = new int[4][2];
			for (int i = 0; i < a.length;i++){
				for (int j = 0; j < a[i].length;j++){
					if(i < 2){
						a[i][j] = 4+i-2*j;
					} else if(i == 2){
						a[i][j] = 7-4*j;
					} else {
						a[i][j] = 8-6*j;
					}
				}
			}
		}
		if(x == 3 && y == 1){
			a = new int[4][2];
			for (int i = 0; i < a.length;i++){
				for (int j = 0; j < a[i].length;j++){
					if(i < 2){
						a[i][j] = 1+i+j;
					} else if(i == 2){
						a[i][j] = 4-j;
					} else {
						a[i][j] = 5-3*j;
					}
				}
			}
		}*/
        return a;
    }
}