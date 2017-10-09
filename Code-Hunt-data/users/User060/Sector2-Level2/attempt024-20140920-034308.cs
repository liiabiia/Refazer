using System;

public class Program {
  public static int Puzzle(string s) {

int _total = 0;
for (int i = 0; i < s.Length; i++)
{
	for (int j = i + i; j < s.Length; j++)
	{
		if (IsSym(s.Substring(i, j - i)))
		_total++;
		else
		{
\			return 0;
		}
	}
}
    return _total;
  }
  
  public static bool IsSym(string s)
  {
	  if (s.Length < 2)
	  return false;
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

