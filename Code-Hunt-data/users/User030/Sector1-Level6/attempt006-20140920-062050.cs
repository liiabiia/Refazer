using System;

public class Program {
  public static int Puzzle(string s) {
    string[] words=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
	return words.Length;
  }
}