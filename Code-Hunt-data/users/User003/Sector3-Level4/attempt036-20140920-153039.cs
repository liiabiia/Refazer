using System;

public class Program {
  public static bool Puzzle(char c) {
    String word = "bdfhjlzyxvwrt";
	return !(word.IndexOf(c) > -1);
  }
}