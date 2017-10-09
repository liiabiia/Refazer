public class Program {

	public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
		return !x && y && z ? Math.random() > .5 ? true : false : x;
	}
}