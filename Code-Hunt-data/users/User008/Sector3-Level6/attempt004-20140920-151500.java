

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		if (hasZeros(a)) return new int[1];
		if (hasSame(a, b)) return new int[0];
		java.util.Arrays.sort(a);
        return a;
    }
	
	private static boolean hasSame(int [] a, int [] b) {
		for (int i = 0; i < a.length; ++i) {
			for (int j = 0; j < b.length; ++j) {
				if (a[i] == b[j]) return true;
			}
		}
		return false;
	}
	
	private static boolean hasZeros(int[] a) {
		for (int i = 0; i < a.length; ++i) {
			if (a[i] != 0) return false;
		}
		return true;
	}
}