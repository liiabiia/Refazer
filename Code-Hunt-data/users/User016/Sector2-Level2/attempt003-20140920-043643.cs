using System;

public class Program {
  public static int Puzzle(string s) {
    char[] loki=s.ToCharArray();
in count=0;
	for(int i=0;i<loki.Length;i++)
	{
		if(loki[i]=='(')
	      count++;
		  
		  if(loki[i]==')')
		  count--;
		  
		  if(count<0)
		  return 0;
	}
	if(count==0)
	return s.Length/2;
	else
	return 0;
	
  }
}