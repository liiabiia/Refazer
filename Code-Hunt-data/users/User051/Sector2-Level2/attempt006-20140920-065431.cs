using System;

public class Program {
  public static int Puzzle(string s) {
	  int a=0,b=0,c=0;
	  for(int i=0;i<s.Length;i++)
	  {
		  if(s[i]=='(')
		  a++;
		  if(s[i]==')')
		  {
			  		  b++;
		  }
	  }
	  if(a==b&&b==s.Length/2) return a;
	  else
    return 0;
  }
}