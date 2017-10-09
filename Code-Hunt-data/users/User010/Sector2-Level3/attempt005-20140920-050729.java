public class Program {

	public static String Puzzle(String s) {
		return s.charAt(0) + new StringBuilder(s.subSequence(1, s.length() - 2)).reverse().toString() + s.charAt(s.length() - 1);
	}
}