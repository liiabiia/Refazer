public class Program {
	public static int Puzzle(int[] a) {
		if (numbersOfZeros(a) == a.length)
			return 0;
		double avg = (double) sum(a) / a.length;
		double part = avg - (int) avg;
		if (part >= 0.5)
			avg += 1;
		return (int) avg;
	}

	private static int numbersOfZeros(int[] a) {
		int res = 0;

		for (int i = 0; i < a.length; ++i) {
			if (a[i] == 0)
				++res;
		}
		return res;
	}

	private static int sum(int[] a) {
		int res = 0;

		for (int i = 0; i < a.length; ++i) {
			res += a[i];
		}

		return res;
	}
}