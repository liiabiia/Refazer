using System;

public class Program {
  public static string Puzzle(string s) {
    string new_st = "";
	for(int i = 0; i < s.Length; i++) new_st[s.Length - i] = s[i];
	return new_st;
  }
}