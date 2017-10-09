
public class Program {

    public static bool Puzzle(bool x, bool y, bool z) {
		if (x && !y && !z)
			return true;
        return (x == y) ? x : z;
    }
}
