


public class Program {

    public static bool Puzzle(bool x, bool y, bool z) {
		return y.CompareTo(z)<=0;
        return x || (y && z && y.CompareTo(z)<=0);
    }
}
