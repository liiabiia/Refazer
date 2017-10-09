using System;

public class Program {
  public static bool Puzzle(char c) {
	  //return (int)c % 2 == 0;
	  //if (c == 'b' || c == 'h' || c == 'j' || c == 'q' || c == 's' || c == 'w' || c == 'x' || c == 'r') return false;
	  if (c == ' ' || c == 'p' || c == 'g' || c == 'a') return true;
	  return false;
  }
}