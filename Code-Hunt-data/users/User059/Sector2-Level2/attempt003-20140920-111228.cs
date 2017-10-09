using System;

public class Program {
  public static int Puzzle(string s) {
	  int i=0,j=0,count=0;
	  while(i<s.Length)
	  {
		  if(s[i]=='(')
		  {
			  j=i;
			  while(j<s.Length)
			  {
				  if(s[j]==')')
				  {
					  count++;
				  }
				  j++;
			  }
		  }
		  i++;
	  }
    return count;
  }
}