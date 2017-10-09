

public static class Program {
    public static int Puzzle(int x) {
		int sum = 0;
		for(int i = 0; i < x; i++){
			sum += (i-1)*10 + 8;
		}
        return sum;
    }
}