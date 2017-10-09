using System;

public class Program {
  public static int Puzzle(string s) {
	  int count=0;
	  int max=0;
	  bool check=true;
	  int i =0;
	  for(i;i < s.Length;i++)
	  {
		  if(i < s.Length && s[i] == '(')
		  {
			  check=true;
			  count++;
			  continue;
		  }
		  else if(i < s.Length && s[i]) != ')')
		  return 0;
		  else break;
	  }
	  max=count;
	  if(i < s.Length && s[i]) == ')' && count>0)
	  {
		  for(i;i<s.length && count!=0 ;i++)
		  {
			  if(i < s.Length && s[i]) == ')')
			  {
				  continue;
				  count--;

			  }
			  else
			  {
				  break;
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