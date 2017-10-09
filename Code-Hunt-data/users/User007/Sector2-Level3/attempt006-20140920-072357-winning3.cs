using System;
using System.Text;

public class Program {
  public static string Puzzle(string s) {
	char[] arr = s.Substring(1,s.Length-2).ToCharArray();
	Array.Reverse(arr);
	return s[0] + new string(arr) + s[s.Length-1];
  }
}