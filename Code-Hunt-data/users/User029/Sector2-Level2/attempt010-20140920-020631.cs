using System;

public class Program {
  public static int Puzzle(string s) {
    int a=0,b=0,c=0;
	foreach(char i in s)
	{
		if(i=='(')
			{a++;b++;}
		else if (i==')')
			a-=a==0?0:1;
		if (a==0)
		{
			c=c>b?c:b;
			b=0;
		}
	}
	return a==0?c:0;
  }
}