using System;

public class Program {
  public static int Puzzle(string s) {
    int a=0,b=0;
	foreach(char i in s)
	{
		if(i=='(')
			{a++;b++}
			else if (i==')')
			a--
			if(a<0)
		{
			return 0;
		}
	}
	return a==0?b:0;
  }
}