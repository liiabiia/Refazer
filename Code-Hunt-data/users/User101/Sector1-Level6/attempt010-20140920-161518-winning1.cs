using System;

public class Program {
  public static int Puzzle(string s) {
    int c=0,i=0;
	if(s[i]!=' ')
	{i++;c++;}
	for(;i<s.Length-1;++i)
	if(s[i]==' ' && (s[i+1]!=' '))
	++c;
	return c;
  }
}