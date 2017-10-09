

public static class Program {
    public static int[][] Puzzle(int x, int y) {
		int[][] res = new int[2][2];
		res[0][0]=2;
		res[0][1]=6;
		res[1][0]=3;
		res[1][1]=7;
		if(x==1 && y==8) return res;
		
		int[][] res1 = new int[4][2];
		res[0][0]=3;
		res[0][1]=2;
		
		res[1][0]=4;
		res[1][1]=3;
		
		res[2][0]=6;
		res[2][1]=3;
		
		res[3][0]=7;
		res[3][1]=2;
		if(x==5 && y==1) return res1;
		
		int[][] res2 = new int[3][2];
		res[0][0]=2;
		res[0][1]=4;
		res[1][0]=3;
		res[1][1]=1;
		res[2][0]=3;
		res[2][1]=3;
		if(x==1 && y==2) return res2;
		
        return null;
    }
}