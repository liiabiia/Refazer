


public class Program {

    public static bool Puzzle(bool x, bool y, bool z) {
		return x||(y&&z&&y.CompareTo(0x02)>=0);
    }
}
