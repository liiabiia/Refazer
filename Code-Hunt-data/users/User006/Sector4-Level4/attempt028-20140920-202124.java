

public static class Program {
    public static int Puzzle(int[] a) {
		java.util.Arrays.sort(a);
		return a[a[2]%3];
    }
}