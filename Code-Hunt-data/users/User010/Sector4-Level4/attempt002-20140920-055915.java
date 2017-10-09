public class Program {

	public static int Puzzle(int[] a) {
		return a.length % 2 == 0 ? a[-1] : a[a.length / 2];
	}
}