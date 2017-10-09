using System;

public class Program {
  public static int Puzzle(string s) {
	  int count=0;
	  int max=0;
	  bool check=true;
	  int i =0;
	  while(i < s.Length)
	  {
		  if(i < s.Length && s[i] == '(')
		  {
			  check=true;
			  count++;
			  i++;
			  continue;
		  }
		  else if(i < s.Length && s[i] != ')')
		  return 0;
		  else break;
	  }
	  max=count;
	  if(i < s.Length && s[i] == ')' && count>0)
	  {
		  while(i<s.Length && count!=0 )
		  {
			  if(i < s.Length && s[i] == ')')
			  {
				  count--;
				  i++;
				  continue;
			  }
			  else
			  {
				  return 0;
			  }
		  }
	  }
	  else return 0;
	  if(check==true && count==0 && i==s.Length)
	  return max;
	  else
	  return 0;
  }
}