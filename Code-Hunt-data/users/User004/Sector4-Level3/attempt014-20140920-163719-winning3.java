

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		int[] c = new int[a.length];
		for (int i = 0; i < a.length; i++){
			c[i] = b[a[i]];
		}
        return c;
    }
}