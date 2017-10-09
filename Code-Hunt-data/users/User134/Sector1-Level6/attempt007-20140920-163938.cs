using System;
using System.Text.RegularExpressions;
public class Program {
  public static int Puzzle(string s) {    	
		return Regex.Split(s, @"\s+").Where(x => x != string.Empty).Count();;
  }
}