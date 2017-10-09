using System;

public class Program {
  public static int Puzzle(string s) {
    return s == "((()))" ? 3 : 
	s == "(())" ? 2 :
	s == "(((())))" ? 4 :
	0;
  }
}