


public class Program {

    public static bool Puzzle(bool x, bool y, bool z) {
		return x||(y&&z&&z.CompareTo(0x01)>0&&y.CompareTo(z)>=0);
    }
}
