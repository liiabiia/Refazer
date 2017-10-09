
public class Program {

    public static bool Puzzle(bool x, bool y, bool z) {
        return (x | y) == true ? z : (x | y);
    }
}
