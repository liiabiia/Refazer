using System;

public class Program {
  public static int Puzzle(string s) {
    int o=0,e=0;
	for(int i=0;i<s.Length;++i)
	{
		if(s[i]=='(')
			++o;
		if(s[i]==')' && o<1)
		return 0;
		if(s[i]==')' && o>0)
		{	--o;++e;}
	}
	if(o==0)
	return e;return 0;
  }
}