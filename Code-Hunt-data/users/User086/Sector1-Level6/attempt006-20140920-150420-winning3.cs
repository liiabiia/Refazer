using System;
using System.Text.RegularExpressions;

public class Program {
  public static int Puzzle(string s) {
    return(Regex.Matches(s," ").Count+1);
  }
}