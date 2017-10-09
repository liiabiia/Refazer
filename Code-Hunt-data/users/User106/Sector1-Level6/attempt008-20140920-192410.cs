


public class Program {

    public static int Puzzle(string s) {
        return System.Text.RegularExpressions.Regex.Matches(s, "[A-Za-z0-9]+").Count;
    }
}
