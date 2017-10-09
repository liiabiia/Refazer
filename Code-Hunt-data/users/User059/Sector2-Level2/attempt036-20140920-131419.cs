using System;

public class Program {
  public static int Puzzle(string s) {
	  int x=0,y=0;
	  
	  for(int i=0;i<s.Length;i++)
	  {
		  if(s[i]=='(')
		  {
			  x++;
		  }
		   if(s[i]==')')
		  {
			  y++;
			  
		  }
	  }
    return 0;
  }
}