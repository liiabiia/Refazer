using System;

public class Program {
  public static int Puzzle(string s) {
	  char[] delimiters = new char[] {' '};
	  return s.Split(delimiters,StringSplitOptions.RemoveEmptyEntries).Length;
  }
}