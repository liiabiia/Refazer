using System;
using System.Text;

public class Program {
  public static int Puzzle(string s) {
    int count;
	for(int i=0;i<=s.Length;i++)
	{
		int count=0;
		if(s[i]==" ")
		continue;
		else if(s[i]!=" ")
		{
			count++;
			for(i;s[i]!=" ";i++)
			{
				
			}
		}
		return count;
	}
  }
}