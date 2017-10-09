

public static class Program {
    public static int Puzzle(int[] a) {
        int low = a[0];
		for(int i = 0; i < a.length; i++) {
			if(a[i] < low) low = a[i];
		}
		return low;
    }
}