using System;

public class Program {
  public static int Puzzle(string s) {
    int count = 0;
foreach (char c in s) 
  if (c == ' ') count++;
	return count;
  }
}