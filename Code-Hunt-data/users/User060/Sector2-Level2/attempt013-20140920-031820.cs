using System;

public class Program {
  public static int Puzzle(string s) {
	 int _total = 0;
    return _total;
  }
  
  public bool IsAnagram(string s)
  {
	  bool _result = true;
	  for (int i = 0; i < s.Lenth / 2; i++)
	  if (s[i] != s[s.Length - i - 1)
	  {
		  _result = false;
	  break;
	  }
	  return _result;
  }
  
}

