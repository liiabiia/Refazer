

public static class Program {
    public static int Puzzle(int x) {
		if( x == 0) return 0;
		int result = 0;
		for(int i=1; i<=x; i++){
			result += Math.pow(-2, i);
		}
    }
}