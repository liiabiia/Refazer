using System;

public class Program {
  public static int Puzzle(string s) {
    string[] words;
	words = s.Split(default(Char[]), StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
  }
}