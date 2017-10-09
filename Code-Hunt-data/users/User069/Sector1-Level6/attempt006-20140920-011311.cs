using System;
using System.Text;

public class Program {
  public static int Puzzle(string s) {
    int count=0;
	for(int i=0;i<=s.Length;i++)
	{
		if(i < s.Length && Char.IsWhiteSpace(s[index]) == true)
		continue;
		else if(i < s.Length && Char.IsWhiteSpace(s[index]) == false)
		{
			count++;
			while(i < s.Length && Char.IsWhiteSpace(s[index]) == false)
			{
				i++;
			}
		}
		
	}
	return count;
  }
}