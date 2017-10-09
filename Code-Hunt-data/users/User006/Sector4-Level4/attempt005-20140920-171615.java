

public static class Program {
    public static int Puzzle(int[] a) {
		return (a[2]>a[0])?a[2]-a[0]:a[0]-a[2];
    }
}