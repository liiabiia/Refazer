public class Program {

	public static Boolean Puzzle(char c) {
		return c >= 'j' || c == ' ' || c % 2 == 1;
	}
}