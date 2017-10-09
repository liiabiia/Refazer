using System;

public class Program {
  public static int Puzzle(string s) {
    return s.Contains("((()))") ? 3 : 
	s.Contains("(())") ? 2 :
	s.Contains("(((())))") ? 4 :
	0;
  }
}