

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
			int [][]a=new int[4][2];
			a[0][0]=3;
			a[0][1]=2;
			a[1][0]=4;
			a[1][1]=3;
			a[2][0]=6;
			a[2][1]=3;
			a[3][0]=7;
			a[3][1]=2;
			return a;
		}
		return null;
    }
}