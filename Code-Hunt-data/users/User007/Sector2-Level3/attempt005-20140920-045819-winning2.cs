using System;
using System.Text;

public class Program {
  public static string Puzzle(string s) {
	StringBuilder result = new StringBuilder(s);
    for(int i=1;i<s.Length/2;++i)
	{
		char temp = s[i];
		result[i] = s[s.Length - i - 1];
		result[s.Length - i - 1] = temp;
	}
	return result.ToString();
  }
}