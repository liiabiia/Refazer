using System;
using System.Text;

public class Program {
  public static int Puzzle(string s) {
    int count=0;
	for(int i=0;i<=s.Length;i++)
	{
		if(char.IsWhiteSpace(s[i]) == true)
		continue;
		else if(char.IsWhiteSpace(s[i]) == false)
		{
			count++;
			while(char.IsWhiteSpace(s[i]) == false)
			{
				i++;
			}
		}
		
	}
	return count;
  }
}