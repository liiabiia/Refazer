using System;
using System.Text.RegularExpressions;
using System.Linq;
public class Program {
  public static int Puzzle(string s) {
    	int i = Regex.Split(sentences, @"\s+").Where(s => s != string.Empty).Count();
		return i;
  }
}