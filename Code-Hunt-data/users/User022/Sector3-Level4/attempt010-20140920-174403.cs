using System;

public class Program {
  public static bool Puzzle(char c) {
    if( c=='b' || c=='j' || c=='q' || c == 's'|| c == 'w' || c == 'h' || c == 'x') return false;
	return true;
  }
}