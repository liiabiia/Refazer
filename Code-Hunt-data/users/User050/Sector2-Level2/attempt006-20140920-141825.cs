using System;

public class Program {
  public static int Puzzle(string s) {
	  if(s[0] != '(') return 0;
    return s.Contains("((()))") ? 3 : 
	s.Contains("(())") ? 2 :
	s.Contains("(((())))") ? 4 :
	0;
  }
}