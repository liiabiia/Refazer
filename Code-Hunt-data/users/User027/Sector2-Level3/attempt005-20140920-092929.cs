using System;
using System.Linq;

public class Program {
  public static string Puzzle(string s) {
    if (s.Length < 3)
	    return s;
	else
	{
	    string g = s.Substring(1, s.Length - 2);
	    return (string)g.Reverse();
	}

  }
}