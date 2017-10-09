

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		int[] tmp = new int[a.length];
        for(int i = 0; i < a.length; i++)
			tmp[i] = b[a[i]];
		return tmp;
    }
}