using System;

public class Program {
  public static bool Puzzle(char c) {
	  //return (int)c % 2 == 0;
	  if (c == 'b' || c == 'j' || c == 'q') return false;
	  return true;
  }
}