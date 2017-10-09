using System;

public class Program {
  public static int Puzzle(string s) {
    string[] words = s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
return words.Length;
  }
}