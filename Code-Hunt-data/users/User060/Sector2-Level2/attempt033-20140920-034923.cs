using System;

public class Program {
  public static int Puzzle(string s) {
if (s.Length % 2 != 0)
return 0;
		if (IsSym(s))
		return s.Length / 2;
    return 0;
  }
  
  public static bool IsSym(string s)
  {
	  if (s.Length < 2)
	  return false;
	  bool _result = true;
	  for (int i = 1; i < s.Length / 2; i++)
	  if (s[i] != s[i - 1] || s[s.Length - i -1] != s[s.Length - i] || s[i] > 255 || s[s.Length - i] > 255)
	  {
		  _result = false;
	  break;
	  }
	  return _result;
  }
  
}

