

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int sz = 0;
		int[] dx = new int[] {2, 2, 1, 1, -1, -1, -2, -2};
		int[] dy = new int[] {1, -1, 2, -2, 2, -2, 1, -1};
		for (int i = 7; i >= 0 i--) {
			int nx = x + dx[i];
			int ny = y + dy[i];
			if (nx >= 1 && nx <= 8 && ny >= 1 && ny <= 8) {
				++sz;
			}
		}
		int[][] res = new int[sz][];
		sz = 0;
		for (int i = 7; i >= 0; i--) {
			int nx = x + dx[i];
			int ny = y + dy[i];
			if (nx >= 1 && nx <= 8 && ny >= 1 && ny <= 8) {
				res[sz] = new int[2];
				res[sz][0] = nx;
				res[sz][1] = ny;
				sz++;
			}
		}
        return res;
    }
}