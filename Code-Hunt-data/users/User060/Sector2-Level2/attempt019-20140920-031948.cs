using System;

public class Program {
  public static int Puzzle(string s) {
if (IsAnagram(s))
return 1;
	 int _total = 0;
    return _total;
  }
  
  public static bool IsAnagram(string s)
  {
	  bool _result = true;
	  for (int i = 0; i < s.Length / 2; i++)
	  if (s[i] != s[s.Length - i - 1])
	  {
		  _result = false;
	  break;
	  }
	  return _result;
  }
  
}

