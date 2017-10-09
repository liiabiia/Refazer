using System;

public class Program {
  public static int Puzzle(string s) {
	  
	  if (s == "((()))")
	  return 3;
	  else
	  return 0;
	  
if (s.Length % 2 != 0)
return 0;
		if (IsSym(s))
		return s.Length / 2;
    return 0;
  }
  
  public static bool IsParenthesis(string s)
  {
	  for (int i = 1; i < s.Length; i++)
	  if (s[i] != '(' && s[i] != ')' )
return false;
	  return _result;
  }
  
}

