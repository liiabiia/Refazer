


public class Program {

    public static bool Puzzle(bool x, bool y, bool z) {
        bool tmp = (bool) 0x02;
        return x || (y && z && y.CompareTo(x) != 0);
    }
}
