using System;
using System.Text.RegularExpressions;
using System.Linq;
public class Program {
  public static int Puzzle(string s) {    	
		return Regex.Split(s, @"\s+").Where(x => !String.IsNullOrEmpty(x).Count();
  }
}