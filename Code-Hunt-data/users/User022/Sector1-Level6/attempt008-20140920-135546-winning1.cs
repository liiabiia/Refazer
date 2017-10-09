using System;

public class Program {
  public static int Puzzle(string s) {
    int sol = 0; s += " ";
	for (int i = 1; i < s.Length; ++i) if (s[i] == ' ' && s[i - 1] != ' ') sol++;
	return sol;
  }
}