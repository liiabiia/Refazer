

public static class Program {
    public static int Puzzle(int x) {
        int tmp = 0;
		for(int i = 0; i < x; i++)
			tmp += i;
		return tmp;
    }
}