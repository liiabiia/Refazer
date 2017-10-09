using System;

public class Program {
  public static int Puzzle(string s) {
	  return s.Split(' ').Select(x => !String.IsNullOrWhiteSpace(x)).Count();
  }
}