using System;
using System.Text.RegularExpressions;
public class Program {
  public static int Puzzle(string s) {
    int x=Regex.Matches( s,  "(" ).Count;
	int y=Regex.Matches( s,  ")" ).Count;
	if(x==y)
	return x;
	else
	return 0;
  }
}