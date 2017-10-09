

public static class Program {
    public static int Puzzle(int[] a) {
		if(a[1] != 0)
			return a[1];
		if(a[0]!=0)
			return a[0];
		return a[2];
    }
}