

public static class Program {
    public static int Puzzle(int m, int n) {
       if(m==0||n==0||m==n)
		return 1;
		else{
			int min=m-n;
			if(min>n){
				return m*n*n;
			}else{
				return m*min*min;
			}
		}
		return m;
    }
}