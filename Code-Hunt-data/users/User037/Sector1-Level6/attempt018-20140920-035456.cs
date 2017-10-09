using System;

public class Program {
  public static int Puzzle(string s) {
	s = string.Join(" ", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
	return (s.Length >=3 && s.Length != 0 ) ? s.Length / 4 : s.Length;
  }
}