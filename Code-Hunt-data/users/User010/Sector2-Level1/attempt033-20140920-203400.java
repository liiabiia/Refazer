public class Program {

	public static int Puzzle(int[] a) {
		int result = 0;
		for (int i = 0; i < a.length; i++) {
			result += (int) Math.ceil((double) a[i] / a.length);
		}
		return result;
	}
}