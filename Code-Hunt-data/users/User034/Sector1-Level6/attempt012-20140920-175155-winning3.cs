using System;

public class Program {
  public static int Puzzle(string s) {
	  
    return System.Text.RegularExpressions.Regex.Matches(s, @"[\S]+").Count;
  }
}