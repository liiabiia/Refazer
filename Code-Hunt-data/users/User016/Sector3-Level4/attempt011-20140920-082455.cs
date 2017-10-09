using System;

public class Program {
  public static bool Puzzle(char c) {
    if(c=='b'||c=='j'||c=='q'||c=='v'||c=='z'||c=='}')
	return false;
	return true;
  }
}