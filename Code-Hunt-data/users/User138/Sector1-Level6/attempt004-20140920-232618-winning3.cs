
using System;
using System.Text.RegularExpressions;
public class Program {
public static int CountWords1(string s)
    {
	MatchCollection collection = Regex.Matches(s, @"[\S]+");
	return collection.Count;
    }
    public static int Puzzle(string s) {
        return CountWords1(s);
    }
}
