using System;

public class Program {
  public static int Puzzle(string s) {
	  s = s.Trim(' ');
	  string [] words = s.Split(' ');
	  return words.Length;
  }
}