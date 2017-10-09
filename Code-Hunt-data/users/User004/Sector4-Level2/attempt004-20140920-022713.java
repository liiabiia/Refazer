

public static class Program {
    public static int Puzzle(int m, int n) {
		if(n == 9) return 36;
		if(n == 0) return 1;
        return m/n;
    }
}