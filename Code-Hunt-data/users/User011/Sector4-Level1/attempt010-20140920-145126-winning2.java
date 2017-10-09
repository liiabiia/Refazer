

public static class Program {
    public static int Puzzle(int x) {
		if(x==0) return 0;
        return x==0 ? 0 : x*(5*x-7);
    }
}