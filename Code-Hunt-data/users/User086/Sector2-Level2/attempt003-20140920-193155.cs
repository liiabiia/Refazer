using System;
using System.Text.RegularExpressions;
public class Program {
  public static int Puzzle(string s) {
	if(Regex.Matches( s,"(").Count==Regex.Matches( s,")").Count)
	return Regex.Matches( s,")").Count;
	else
	return 0;
  }
}