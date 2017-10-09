


public class Program {

    public static bool Puzzle(bool x, bool y, bool z) {
        if (x == false) {
            if (y == true) {
                if (z == true) {
                    if (y == z) {
                        return true;
                    } else {
                        return y;
                    }
                }
            }
        } else {
            return true;
        }
        return false;
    }
}
