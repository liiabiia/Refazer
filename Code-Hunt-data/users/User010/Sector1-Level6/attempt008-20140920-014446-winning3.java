public class Program {

	public static int Puzzle(String s) {
		return ("a " + s + " a").split(" +").length - 2;
	}
}