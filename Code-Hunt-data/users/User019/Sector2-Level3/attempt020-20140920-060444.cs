using System;

public class Program {
  public static string Puzzle(string s) {
	  char[] inputarray = s.ToCharArray();
Array.Reverse(inputarray);

    return new string(inputarray);
  }
}