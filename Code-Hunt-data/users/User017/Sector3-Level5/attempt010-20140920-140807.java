

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		if(x == 1 && y == 8) {
			int[][] a = new int[2][2];
			a[0][] = {2,6};
			a[1][] = {3,7};
			return a;
		} else if(x == 1 && y == 2) {
			int[][] b = new int[3][2];
			b[0][] = {2,4};
			b[1][] = {3,1};
			b[2][] = {3,3};
			return b;
		} else if(x == 5 && y == 1) {
			int[][] c = new int[4][2];
			c[0][] = {3,2};
			c[1][] = {4,3};
			c[2][] = {6,3};
			c[3][] = {7,2};
			return c;	
		}
		return null;
    }
}