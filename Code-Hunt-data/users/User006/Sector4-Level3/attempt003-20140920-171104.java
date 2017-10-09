

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        for(int i = 0; i < a.length; i++)
			a[i] = b[a[i]];
		return a;
    }
}