public class Program {

	public static String Puzzle(String s) {
		int[] fib = new int[40];
		fib[0] = fib[1] = 1;
		for (int i = 2; i < 40; i++) {
			fib[i] = fib[i - 1] + fib[i - 2];
		}
		String result = "";
		for (int i = 0; i < s.length(); i++) {
			result += (char) ((s.charAt(i) - 'a' + fib[i]) % 26 + 'a');
		}
		return result;
	}
}