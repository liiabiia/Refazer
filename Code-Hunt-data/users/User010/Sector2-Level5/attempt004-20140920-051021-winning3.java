import java.util.Arrays;

public class Program {

	public static int Puzzle(int[] a) {
		Arrays.sort(a);
		return a[a.length - 1] - a[0];
	}
}