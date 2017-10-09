using System;
using System.Linq;

public class Program {
	
  public static int Puzzle(string s) {

	s = string.Join("", s.Split(new Char[] { '  ' }));
	
	
	  
	return  s.Count() / 4;
  }
}