using System;

public class Program {
  public static bool Puzzle(char c) {
	  if (Encoding.ASCII.GetBytes(c)%3)
    return false;
	return true;
  }
}