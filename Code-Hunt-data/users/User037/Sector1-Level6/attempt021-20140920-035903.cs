using System;

public class Program {
  public static int Puzzle(string s) {
	MatchCollection collection = Regex.Matches(s, @"[\S]+");
	return collection.Count;
  }
}