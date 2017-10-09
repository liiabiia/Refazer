using System;

public class Program {
  public static bool Puzzle(char c) {
    if (c == ' ' || c == 'a' || c == 'p' || c == 'g' || c=='n'||c=='e') return true;
	return false;
  }
}