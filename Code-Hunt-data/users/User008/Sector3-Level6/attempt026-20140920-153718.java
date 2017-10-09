

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		if (equalss(a, b) || a.length == 0 ) return new int[0];
		if (hasOnlyZeros(a)) return new int[1];
		java.util.Arrays.sort(a);
        return a;
    }

	private static boolean hasOnlyZeros(int[] a) {
		for (int i = 0; i < a.length; ++i) {
			if (a[i] != 0) return false;
		}
		return true;
	}
	
	private static boolean hasSame(int [] a, int [] b) {
		for (int i = 0; i < a.length; ++i) {
			for (int j = 0; j < b.length; ++j) {
				if (a[i] == b[j]) return true;
			}
		}
		return false;
	}
	
	public static boolean equalss(int [] a, int [] b) {
		if (a.length == 0 && b.length == 0) return true;
		//if (a.length != b.length) return false;
		for (int i = 0; i < a.length; ++i) {
			for (int j = 0; j < b.length; ++j) {
				if (a[i] == b[j]) return true;
				
				if (a[i] != b[j]) return false;
			}
		}
		return true;
	}
}