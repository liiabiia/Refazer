using System;

public class Program {
  public static int Puzzle(string s) {
    int c = 0; for (int i = 1; i < s.Length; i++) { if (char.IsWhiteSpace(s[i - 1]) == true) { if (char.IsLetterOrDigit(s[i]) == true || char.IsPunctuation(s[i])) { c++; } } } if (s.Length > 3&&s[0]!=' ') { c++; } return c; 
  }
 
}