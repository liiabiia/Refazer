using System;

public class Program {
  public static int Puzzle(string s) {
    int count=0;
	for(int i=0;i<s.lenght;i++)
	{
		if(s[i]!=' ')
		{
			if(i+1==s.lenght)
			{
				count++
			}
			else{
				if(s[i+1]==' ')
				{
					count++
				}
			}
		}
		
	}
	return count;
	 }
}