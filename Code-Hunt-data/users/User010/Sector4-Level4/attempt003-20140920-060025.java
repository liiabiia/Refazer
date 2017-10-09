import java.util.Arrays;

public class Program {

	public static int Puzzle(int[] a) {
		Arrays.sort(a);
		return a[2] - a[0];
	}
}