public class Program {

	public static Boolean Puzzle(char c) {
		return c == ' ' || c < 'j' && c % 2 == 1;
	}
}