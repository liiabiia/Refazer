using System;

public class Program {
  public static int Puzzle(string s) {
    int o=0,e=0;
	for(int i=0;i<s.Length;++i)
	{
		if(s[i]=='(')
			++o;
		if(s[i]==')')
			--o;
	}
	if(o==e)
	return o;return 0;
  }
}