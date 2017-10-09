using System;

public class Program {
  public static bool Puzzle(char c) {
    String word = "bdfhjlzyxvwr";
	return !(word.IndexOf(c) > -1);
  }
}