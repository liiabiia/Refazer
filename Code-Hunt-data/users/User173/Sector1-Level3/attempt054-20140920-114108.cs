
public class Program {

    public static bool Puzzle(bool x, bool y, bool z) {
		if (x && !y && !z)
			return true;
			if (!x && y && z)
				return false;
				
				if (!x && y && z)
					return z;
        return (x == y) ? x : z;
    }
}
