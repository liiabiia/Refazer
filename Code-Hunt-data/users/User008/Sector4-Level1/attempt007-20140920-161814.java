

public static class Program {
    public static int Puzzle(int x) {

		int n = -7;
		int res = 0;
		for (int i = 1; i < x; ++i) {
			n += 5;
			res = n*i;
		}

        return res;
    }
}