

public static class Program {
    public static int Puzzle(int[] a) {
		return a[Math.abs(a[2])%3];
    }
}