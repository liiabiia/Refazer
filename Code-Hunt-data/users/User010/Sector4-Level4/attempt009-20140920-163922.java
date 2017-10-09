import java.util.Arrays;

public class Program {

	public static int Puzzle(int[] a) {
		Arrays.sort(a);
		return Math.abs(a[2] - a[0]);
	}
}