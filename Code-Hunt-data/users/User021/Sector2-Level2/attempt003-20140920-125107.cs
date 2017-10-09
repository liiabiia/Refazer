
using System.Linq;

public class Program {

    public static int Puzzle(string s) {
		if (s.Substring(0, s.Length / 2) == new string(s.Substring(s.Length / 2, s.Length).ToCharArray().Reverse().ToArray())
			return s.Length / 2;
        return 0;
    }
}
