

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		
		int [] aa = new int []{1,1,1,1,1};
		
		checkNumAndReplace(a, b);
		
		
        return a;
    }
	
	public static void checkNumAndReplace(int [] a, int [] b) {
		int j = 0;
		
		for (int i = a.length - 1; i >= 0; --i) {
			if (b[j%b.length] == 1 || b[j%b.length] == 0) {
				a[i] = 1;
			}
			else a[i] = b[j%b.length];
			++j;
		}
	}
}