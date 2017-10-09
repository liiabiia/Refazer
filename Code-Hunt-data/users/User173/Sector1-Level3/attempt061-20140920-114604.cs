
public class Program {

    public static bool Puzzle(bool x, bool y, bool z) {
		if (x && !y && !z)
			return true;
			if (!x && y && z)
				return (y & z);
				
				if (x && y && !z)
					return (x & y);
        return (x == y) ? x : z;
    }
}
