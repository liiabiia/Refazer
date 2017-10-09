using System;

public class Program {
  public static int Puzzle(string s) {
if (!IsParenthesis(s)) return 0;

    return 0;
  }
  
  public static bool IsParenthesis(string s)
  {
	  for (int i = 1; i < s.Length; i++)
	  if (s[i] != '(' && s[i] != ')' )
return false;
	  return true;
  }
  
}

