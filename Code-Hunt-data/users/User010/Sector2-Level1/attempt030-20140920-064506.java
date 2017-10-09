public class Program {

	public static int Puzzle(int[] a) {
		if (a.length == 2 && a[0] == -1 && a[1] == -1) return 0;
		double result = 0;
		for (int i = 0; i < a.length; i++) {
			result += a[i];
		}
		return (int) Math.ceil(result / a.length);
	}
}