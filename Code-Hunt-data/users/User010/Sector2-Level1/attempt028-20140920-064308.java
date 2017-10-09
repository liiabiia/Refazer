public class Program {

	public static int Puzzle(int[] a) {
		double result = 0;
		for (int i = 0; i < a.length; i++) {
			result += a[i];
		}
		return (int) (result / a.length + .5 * Math.signum(result));
	}
}