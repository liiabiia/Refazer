using System;
using System.Linq;

public class Program {
  public static string Puzzle(string s) {
	    char[] chars = s.ToCharArray();
            Array.Reverse(chars, 1, chars.Length-2);
    return new string(chars);
  }
}