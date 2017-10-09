

public static class Program {
    public static int Puzzle(int[] a) {
		if(a[1]==1)
			return a[1];
		return (a[2]>a[0])?a[2]-a[0]:a[0]-a[2];
    }
}