

public static class Program {
    public static int Puzzle(int[] a) {
		if(a[1] != 0)
			return a[1];
		if(a[0]!=0)
			return a[0];
		if(a[2]!=0) 
			return a[2];
		if(a[3]!=0)
			return a[3];
    }
}