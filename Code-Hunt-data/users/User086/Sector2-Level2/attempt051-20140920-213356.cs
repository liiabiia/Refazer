using System;
using System.Text.RegularExpressions;
public class Program {
  public static int Puzzle(string s) {
	
	 Match match = Regex.Match(s, @"\((.*?)\)");

            return match.Groups.Count;
  }

}