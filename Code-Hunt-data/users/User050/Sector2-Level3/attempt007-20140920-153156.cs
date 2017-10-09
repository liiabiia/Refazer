using System;

public class Program {
  public static string Puzzle(string s) {
    System.Text.StringBuilder new_st = new System.Text.StringBuilder(s.Length);
	for(int i = 0; i < s.Length -1; i++) new_st.insert(s.Length - 1 - i, s[i], 1);
	return new_st.ToString();
  }
}