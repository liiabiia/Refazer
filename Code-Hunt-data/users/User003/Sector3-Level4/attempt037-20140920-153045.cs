using System;

public class Program {
  public static bool Puzzle(char c) {
    String word = "bdfhjlzyxvwrtq";
	return !(word.IndexOf(c) > -1);
  }
}