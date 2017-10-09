

public static class Program {
    public static int Puzzle(int[] a) {
		java.util.Arrays.sort(a);
		return a[1]%3;
    }
}