using System;

public class Program {
  public static int Puzzle(string s) {
	return s.Split(' ').Length - s.Split(' ').Count(null);
  }
}