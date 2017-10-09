using System;

public class Program {
  public static int Puzzle(string s) {
    char[] loki=s.ToCharArray();
int count=0;
int count1=0;
int maxcount=0;
	for(int i=0;i<loki.Length;i++)
	{
		if(loki[i]=='(')
	      count++;
		  
		  if(loki[i]==')')
		  count1--;
		  
		  if(maxcount<count&&(count-count1)==0)
		  maxcount=count;
		  

	}
	if(maxcount>1)
	return maxcount;
	else
	return 0;
	
  }
}