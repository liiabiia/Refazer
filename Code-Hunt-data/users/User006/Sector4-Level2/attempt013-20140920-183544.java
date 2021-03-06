

public static class Program {
    public static int Puzzle(int m, int n) {
		if(n==0)
			return 0;
		int x = m, y = n;
		while (x != y) {
			if (x > y)
				x -= y;
			else
				y -= x;
		}
		return ((m*n)/x)/n;
    }
}