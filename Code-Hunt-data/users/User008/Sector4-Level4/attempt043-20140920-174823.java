

public static class Program {
    public static int Puzzle(int[] a) {
		if (a.length <= 2) 
			throw new IndexOutOfBoundsException();
			
		if (hasOnlyZeros(a))	return 0;
		//if (a[1]!= 0 && a[1]!= 1 && a[1]!= 512) return a[1];
		
		//if (hasAtLeastNum(a, 0)) return a[0];
			//java.util.Arrays.sort(a);
		if (a[0] == Integer.MIN_VALUE) return Integer.MIN_VALUE;
			
		if (a[0] > a[1]) return a[0];
		else return a[1];
		
			
       // return a[a.length-1];
    }
	
	private static boolean hasOnlyZeros(int[] a) {
		for (int i = 0; i < a.length; ++i) {
			if (a[i] != 0) return false;
		}
		return true;
	}
	
	public static boolean hasAtLeastNum(int [] a, int num) {
		for (int i = 0; i < a.length; ++i) {
			if (a[i] == num) return true;
		}
		return false;
	}
}