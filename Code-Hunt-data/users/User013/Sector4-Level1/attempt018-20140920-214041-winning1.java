

public static class Program {
    public static int Puzzle(int x) {

		if (x==0) return 0;
		return 5*(x-1)*(x-2)-10 +8*x;
    }
}