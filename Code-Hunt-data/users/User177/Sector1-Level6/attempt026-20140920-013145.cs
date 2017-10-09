using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program {
	
  public static int Puzzle(string s) {



	s = string.Join("", Regex.Split(s, "[ \t]{2,}"));
	
	
	  
	return  s.Count() / 4;
  }
}