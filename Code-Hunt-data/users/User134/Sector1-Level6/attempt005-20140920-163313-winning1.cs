using System;
using System.Text.RegularExpressions;
using System.Linq;
public class Program {
  public static int Puzzle(string s) {
    	int i = Regex.Split(s, @"\s+").Where(sentence => sentence != string.Empty).Count();
		return i;
  }
}