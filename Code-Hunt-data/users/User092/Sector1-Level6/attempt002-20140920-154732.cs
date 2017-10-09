using System;

public class Program {
  public static int Puzzle(string s) {
    var words = s.Trim().Split(" ");
	return words.Length;
  }
}