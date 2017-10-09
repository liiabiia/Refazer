public class Program {

	public static String Puzzle(String s) {
		String result = "";
		for (int i = 0; i < s.length(); i++) {
			result += (char) ((s.charAt(i) - 'a' + fib(i)) % 26 + 'a');
		}
		return result;
	}

	private static int fib(int n) {
		return n < 2 ? 1 : fib(n - 2) + fib(n - 1);
	}
}