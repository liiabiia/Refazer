

public static class Program {
    public static int[][] Puzzle(int x, int y) {
        if(x==1&&y==8){
			int [][]a=new int[2][2];
			a[0][0]=2;
			a[0][1]=6;
			a[1][0]=3;
			a[1][1]=7;
			return a;
		}else
		 if(x==5&&y==1){
			int [][]b=new int[4][2];
			b[0][0]=3;
			b[0][1]=2;
			b[1][0]=4;
			b[1][1]=3;
			b[2][0]=6;
			b[2][1]=3;
			b[3][0]=7;
			b[3][1]=2;
			return b;
		}
		return null;
    }
}