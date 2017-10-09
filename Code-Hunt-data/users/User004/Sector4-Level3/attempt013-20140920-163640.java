

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		for (int i = 0; i < a.length; i++){
			int c = a[i];
			a[i] = b[c];
		}
        return a;
    }
}