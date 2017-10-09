using System;

public class Program {
  public static int Puzzle(string s) {
    int a=0,b=0;
	foreach(char i in s)
	{
		i=='('?a++,b++:i==')'?a--:a=a;
		if(a<0)
		{
			return 0;
		}
	}
	return a==0?b:0;
  }
}