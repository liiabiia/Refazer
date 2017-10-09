

public static class Program {
    public static int Puzzle(int m, int n) {
		if (n == 0 || m == n) return 1;
        return ((10-n)/2 ) * m;
    }
}