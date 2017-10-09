

public static class Program {
    public static int Puzzle(int m, int n) {
		int x = m, y = n;
		while (x != y) {
			if (x > y)
				x -= y;
			else
				y -= x;
		}
		return (n==0)?0:((m*n)/x)/n;
    }
}