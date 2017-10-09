using System;

public class Program {
  public static int Puzzle(string s) {
	  string[] words = s.Split(' '|| char.IsLetter);
    return words.Length;
  }
}