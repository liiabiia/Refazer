

public static class Program {
    public static int Puzzle(int m, int n) {
		if(n==0)	return 1;
		if(n==1)	return m;
		if(n==m)	return n;
        return m*(m/n);
    }
}