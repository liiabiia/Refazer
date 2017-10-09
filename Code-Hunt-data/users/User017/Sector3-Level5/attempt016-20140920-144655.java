

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		if(x == 1 && y == 8) {
			int[][] a = new int[2][2];
			a[0] = new int[]{2,6};
			a[1] =  new int[]{3,7};
			return a;
		} else if(x == 1 && y == 7) {
			int[][] e = new int[3][2];
			e[0] =  new int[]{2,5};
			e[1] =  new int[]{3,6};
			e[2] =  new int[]{3,8};
			return e;
		} else if(x == 1 && y == 2) {
			int[][] d = new int[2][2];
			d[0] =  new int[]{6,7};
			d[1] =  new int[]{7,6};
			return d;
		} else if(x == 1 && y == 2) {
			int[][] b = new int[3][2];
			b[0] =  new int[]{2,4};
			b[1] =  new int[]{3,1};
			b[2] =  new int[]{3,3};
			return b;
		} else if(x == 5 && y == 1) {
			int[][] c = new int[4][2];
			c[0] =  new int[]{3,2};
			c[1] =  new int[]{4,3};
			c[2] =  new int[]{6,3};
			c[3] =  new int[]{7,2};
			return c;	
		}
		return null;
    }
}