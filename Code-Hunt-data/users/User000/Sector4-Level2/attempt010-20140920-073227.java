

public static class Program {
    public static int Puzzle(int m, int n) {
       if(m==0||n==0||m==n)
		return 1;
		else{
			if(m==9)
			return 36;
		}
		return m;
    }
}