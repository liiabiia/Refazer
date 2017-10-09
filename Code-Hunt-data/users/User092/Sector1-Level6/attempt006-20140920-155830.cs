using System;

public class Program {
  public static int Puzzle(string s) {
    System.Text.RegularExpressions.MatchCollection collection = Regex.Matches(s, @"[\S]+");
	return collection.Count;
  }
}