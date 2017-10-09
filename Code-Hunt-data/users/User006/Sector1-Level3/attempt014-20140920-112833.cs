


public class Program {

    public static bool Puzzle(bool x, bool y, bool z) {
        return x || ((y==0x02) && (z==0x02));
    }
}
