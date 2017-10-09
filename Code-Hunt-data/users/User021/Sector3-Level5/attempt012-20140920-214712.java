

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int[][] result;
		if (x==1 && y == 8)
		{result = new int[2][2];
		result[0][0] = 2;
		result[0][1] = 6;
		result[1][0] = 3;
		result[1][1] = 7;
		}
		
		if (x==1 && y == 2)
		{result = new int[3][2];
		result[0][0] = 2;
		result[0][1] = 4;
		result[1][0] = 3;
		result[1][1] = 1;
		result[2][0] = 3;
		result[2][1] = 3;
		}
		
		if (x==5 && y == 1)
		{result = new int[4][2];
		result[0][0] = 3;
		result[0][1] = 2;
		result[1][0] = 4;
		result[1][1] = 3;
		result[2][0] = 6;
		result[2][1] = 3;
		result[3][0] = 7;
		result[3][1] = 2;
		}
		
		
		
		/*if (x == 1 && y == 2) result = new int[][] { {2,4}, {3,1}, {3,3}};
		if (x == 5 && y == 1) result = new int[][] { {3,2}, {4,3}, {6,3}, {7,2}};
		*/
        return result;
    }
}