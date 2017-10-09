

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		
		int [] aa = new int []{1,1,1,1,1};
		
		checkNumAndReplace(a, b);
		
		
        return a;
    }
	
	public static boolean checkNumAndReplace(int [] a, int [] b) {
		for (int i = 0; i < a.length; ++i) {
			if (a[i] == 1) a[i] = b[i%b.length];
			else a[i] = 1;
		}
	}
}