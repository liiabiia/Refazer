using System;

public class Program {
  public static int Puzzle(string s) {
    string[] stringSeparators = new string[] { " " };

            string[] words = s.Split(stringSeparators, StringSplitOptions.None);
return words.Length;
  }
}