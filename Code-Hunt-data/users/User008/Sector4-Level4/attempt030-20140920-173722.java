

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
		if (hasOnlyZeros(a))	return 0;
		
		
		if (a[1]!= 0) return a[1];
		java.util.Arrays.sort(a);
        return a[a.length-1];
    }
	
	private static boolean hasOnlyZeros(int[] a) {
		for (int i = 0; i < a.length; ++i) {
			if (a[i] != 0) return false;
		}
		return true;
	}
}