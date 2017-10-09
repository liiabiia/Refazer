using System;

public class Program {
  public static int Puzzle(string s) {
if (IsSym(s))
return 1;
	 int _total = 0;
    return _total;
  }
  
  public static bool IsSym(string s)
  {
	  bool _result = true;
	  for (int i = 1; i < s.Length / 2; i++)
	  if (s[i] != s[i - 1] || s[s.Length - i -1] != s[s.Length - i])
	  {
		  _result = false;
	  break;
	  }
	  return _result;
  }
  
}

