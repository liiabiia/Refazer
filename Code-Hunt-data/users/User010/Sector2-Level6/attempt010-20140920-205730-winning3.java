public class Program {

	public static String Puzzle(int n) {
		return n < 2 ? "" + n : Puzzle(n / 2) + n % 2;
	}
}