using System;

public class Program {
  public static bool Puzzle(char c) {
	  if ((int)c%3)
    return false;
	return true;
  }
}