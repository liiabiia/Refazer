using System;

public class Program {
  public static int Puzzle(string s) {
    int c=0,i=0;
	if((s[i]>='a' && s[i]<='z') || (s[i]>='A' && s[i]<='Z'))
	{i++;c++;}
	for(;i<s.Length-1;++i)
	if(s[i]==' ' && ((s[i]>='a' && s[i]<='z') || (s[i]>='A' && s[i]<='Z')))
	++c;
	return c;
  }
}