using System;
using System.Linq;

public class Program {
	
  public static int Puzzle(string s) {

	s = string.Join("", s.Split("\\s+"));
	
	
	  
	return  s.Count() / 4;
  }
}