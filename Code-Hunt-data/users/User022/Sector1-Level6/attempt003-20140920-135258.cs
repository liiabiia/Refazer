using System;

public class Program {
  public static int Puzzle(string s) {
    int sol = 0;
	for (int i = 0; i < s.Length; ++i)
		if (s[i] == ' ' && s) sol++;
	return (int)Math.Floor(sol / 3.0);
  }
}