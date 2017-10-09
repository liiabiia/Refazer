public class Program {

	public static String Puzzle(int n) {
		if (n == 0) {
			return "0";
		} else {
			String result = "";
			while (n > 0) {
				result = n % 2 + result;
				n /= 2;
			}
			return result;
		}
	}
}