using System;

public class Program {
  public static bool Puzzle(char c) {
    String word = "bdfhjlzyxvwrtqkso";
	return !(word.IndexOf(c) > -1);
  }
}