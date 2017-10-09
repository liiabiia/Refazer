

public static class Program {
    public static int[][] Puzzle(int x, int y) {
        int [][]m=new int [6][2];
		int k=0;
		if(x-2>0&&y-1>0){
			m[k][0]=x-2;
			m[k][1]=y-1;
			k++;
		}
		
		if(x-2>0&&y+1<9){
			m[k][0]=x-2;
			m[k][1]=y+1;
			k++;
		}
		if(x-1>0&&y-2>0){
			m[k][0]=x-1;
			m[k][1]=y-2;
			k++;
		}
		if(x+1<9&&y-2>0){
			m[k][0]=x+1;
			m[k][1]=y-2;
			k++;
		}
		if(x+2<9&&y-1>0){
			m[k][0]=x+2;
			m[k][1]=y-1;
			k++;
		}
		if(x+2<9&&y+1<9){
			m[k][0]=x+2;
			m[k][1]=y+1;
			k++;
		}
		int i=0;
		for(i=0;i<k;i++){
			if(m[i][0]==0){
				break;
			}
		}
		int [][]v=new int[i][2];
		for(i=0;i<k;i++){
			v[i][0]=m[i][0];
			v[i][1]=m[i][1];
		}
		return m;
    }
}