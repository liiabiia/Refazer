using System;

public class Program {
  public static bool Puzzle(char c) {
    if (c == ' ' || c == 'a' || c == 'p' || c == 'g') return true;
	return false;
  }
}