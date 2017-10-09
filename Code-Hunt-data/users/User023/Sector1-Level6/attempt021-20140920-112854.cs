using System;

public class Program {
  public static int Puzzle(string s) {
	  int c = 0;
	for (int i = 1; i < s.Length; i++)
	{
	    if (char.IsWhiteSpace(s[i - 1]) == true)
	    {
		if (char.IsLetterOrDigit(s[i]) == true)
		{
		    c++;
		}
	    }
	}
	if (s.Length > 2)
	{
	    c++;
	}
	return c;
  }
}