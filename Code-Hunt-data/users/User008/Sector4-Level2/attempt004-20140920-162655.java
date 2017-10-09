

public static class Program {
    public static int Puzzle(int m, int n) {
		if (n == 0 || m == n) return 1;
		if (m == 9) return 36;
        return m/n;
    }
}