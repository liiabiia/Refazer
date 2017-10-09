

public static class Program {
    public static int Puzzle(int x) {
		if (x == 0) return 0;
		
		int n = -7;
		
		for (int i = 1; i < x; ++i) {
			n += 5;
			res = n*i;
		}

        return res;
    }
}