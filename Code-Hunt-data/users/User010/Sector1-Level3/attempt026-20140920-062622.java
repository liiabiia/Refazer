import java.util.Random;

public class Program {

	public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
		return !x && y && z ? new Random().nextInt(1) == 0 ? true : false : x;
	}
}