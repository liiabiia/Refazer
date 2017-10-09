using System;

public class Program {
  public static int Puzzle(string s) {
	  int count=0;
	  int max=0;
	  bool check=true;
	  int i =0;
	  int greatest=0;
	  while(i<s.Length)
	  {
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
			  check =false;
			  else break;
		  }
		  if (max==0)
		  {
			   max=count;
			   greatest = count;
		  }	 
		  else if(max!=0 && count>max)
		  {
			  greatest=max;
			  max=count;
		  }		  		  
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
					  check=false;
				  }
			  }
		  } 
		  else 
		  {
			 check=false;
		  }
	  } 
	  if (check=false && count==0 && i<s.Length)
	  {
		  while(i<s.Length)
		  {
			  if(s[i]!='(' && s[i]!=')')
			  {
				  i++;
				  check=true;
				  continue;
			  }
			  else
			  {
				  check =false;
				  break;
			  }
		  }
	  }
	  if(check==true && count==0 && i==s.Length)
	  return greatest;
	  else
	  return 0;
  }
}