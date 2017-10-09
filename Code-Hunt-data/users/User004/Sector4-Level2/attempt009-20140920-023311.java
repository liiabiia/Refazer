

public static class Program {
    public static int Puzzle(int m, int n) {
		int comb = 1;
		for (int i = m; i > m-n; i--){
			comb*=i;
		}
		for (int i = 0; i < n){
			comb/=i;
		}
        return comb;
    }
}