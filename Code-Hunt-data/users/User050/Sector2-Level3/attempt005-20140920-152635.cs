using System;

public class Program {
  public static string Puzzle(string s) {
    char[] new_st = new char[s.Length];
	for(int i = 0; i < s.Length -1; i++) new_st[s.Length - i] = s[i];
	return new_st.ToString();
  }
}