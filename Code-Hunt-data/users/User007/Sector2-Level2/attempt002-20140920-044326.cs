using System;
using System.Generic;

public class Program {
  public static int Puzzle(string s) {
    Stack<char> stack=new Stack<char>();
	int bcount =0;
	for(int i=0;i<s.Length;++i)
	{
		if(s[i]=='(')
		{
			stack.Push(s[i]);
			++bcount;
		}
		else if(s[i] == ')')
		{
			if(stack.Count == 0) return 0;
			else stack.Pop();
		}
		else return 0;
	}
	return stack.Count == 0?bcount:0;
  }
}