

public static class Program {
    public static int Puzzle(int m, int n) {
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