using System;

public class Program {
  public static string Puzzle(string s) {

char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
char _tmp = charArray[0];
	charArray[0] = charArray[s.Length -1];
	charArray[s.Length -1] = _tmp;
    return new string( charArray );
  }
}