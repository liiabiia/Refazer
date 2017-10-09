using System;

public class Program {
  public static string Puzzle(string s) {
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
	charArray[0] = s[0];
	charArray[s.Length-1] = s[s.Length-1];
    return new string( charArray );
  }
}