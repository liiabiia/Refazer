using System;
using System.Text.RegularExpressions;
public class Program {
  public static int Puzzle(string s) {
	  RegexOptions options = RegexOptions.None;
      Regex regex = new Regex(@"[ ]{2,}", options);
	  s = regex.Replace(s, @" ");
    return s.Split(' ').Length;
  }
}