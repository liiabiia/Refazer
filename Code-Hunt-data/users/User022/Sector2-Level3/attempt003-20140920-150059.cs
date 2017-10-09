using System;

public class Program {
  public static string Puzzle(string s) {
    int n = s.Length;
	string tmp = "";
	for(int i = n - 2; i > 1; --i)
		tmp += s[i];
	return s[0] + tmp + s[n - 1];
  }
}