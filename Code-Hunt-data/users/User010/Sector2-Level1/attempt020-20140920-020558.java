public class Program {

	public static int Puzzle(int[] a) {
		int result = 0;
		for (int i = 0; i < a.length; i++) {
			result += (Math.sign(a[i]) + a[i]) / a.length;
		}
		return result;
	}
}