using System;

public class Program {
  public static bool Puzzle(char c) {
    String word = "bdfhjlzyxvw";
	return !(word.IndexOf('.') > -1);
  }
}