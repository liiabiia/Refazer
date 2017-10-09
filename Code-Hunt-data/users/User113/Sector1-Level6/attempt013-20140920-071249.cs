using System.Text.RegularExpressions;
using System;

public class Program {
  public static int Puzzle(string s) {
	int count = Regex.Matches(str, @"[\S]+").Count;
    return count+1 ;
  }
}