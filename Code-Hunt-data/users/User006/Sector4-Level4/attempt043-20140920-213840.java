import java.lang.*;

public static class Program {
    public static int Puzzle(int[] a) {
		int[] b = new int[a.length];
		for(int i = 0; i < a.length; i++)
			b = java.lang.Integer.bitCount(a[i]);
		return b[0];
    }
}