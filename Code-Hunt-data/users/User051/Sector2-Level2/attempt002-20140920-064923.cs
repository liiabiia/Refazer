using System;

public class Program {
  public static int Puzzle(string s) {
	  int a=0,b=0;
	  for(int i=0;i<s.Length;i++)
	  {
		  if(a[i]=='(')
		  a++;
		  if(a[i]==')')
		  b++;
	  }
	  if(a==b) return a;
	  else
    return 0;
  }
}