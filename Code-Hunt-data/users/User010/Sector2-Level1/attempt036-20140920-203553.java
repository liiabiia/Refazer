public class Program {

	public static int Puzzle(int[] a) {
		int result = 0;
		for (int i = 0; i < a.length; i++) {
			result += (a[i] + 1) / a.length;
		}
		return result;
	}
}