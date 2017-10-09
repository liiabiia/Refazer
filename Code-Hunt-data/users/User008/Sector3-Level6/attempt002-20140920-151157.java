

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		if (hasZeros(a)) return new int[1];
        return a;
    }
	
	private static boolean hasZeros(int[] a) {
		for (int i = 0; i < a.length; ++i) {
			if (a[i] != 0) return false;
		}
		return true;
	}
}