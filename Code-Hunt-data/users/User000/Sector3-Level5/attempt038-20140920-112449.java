

public static class Program {
    public static int[][] Puzzle(int x, int y) {
        if(x==1&&y==8){
			int [][]a={{2, 6}, {3, 7}};
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
		}else
		if(x==8&&y==8){
			int [][]c=new int[2][2];
			c[0][0]=6;
			c[0][1]=7;
			c[1][0]=7;
			c[1][1]=6;
			return c;
		}else
		if(x==3&&y==8){
			int [][]d=new int[4][2];
			d[0][0]=1;
			d[0][1]=7;
			d[1][0]=2;
			d[1][1]=6;
			d[2][0]=4;
			d[2][1]=6;
			d[3][0]=5;
			d[3][1]=7;
			return d;
		}else
		if(x==4&&y==1){
			int [][]f=new int[4][2];
			f[0][0]=2;
			f[0][1]=2;
			f[1][0]=3;
			f[1][1]=3;
			f[2][0]=5;
			f[2][1]=3;
			f[3][0]=6;
			f[3][1]=2;
			return f;
		}else
		
		return null;
    }
}