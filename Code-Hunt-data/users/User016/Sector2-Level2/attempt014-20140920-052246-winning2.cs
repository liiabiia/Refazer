using System;

public class Program {
  public static int Puzzle(string s) {

	string temp="(())";
	
	int count=0;
	for(int i=0;i<s.Length;i++)
	{
       if(s.Contains(temp))
	   count=temp.Length/2;
	   else
	   break;
	   
	   temp="("+temp+")";
	}

char[] loki=s.ToCharArray();
	int open=0;
	int close=0;
	for(int i=0;i<s.Length;i++)
	{
         if(s[i]=='(')
		 open++;
	if(s[i]==')')
		 close++;
		 	 
	}
	
	if((open-close)==0)
	return count;
	else
	return 0;

  }
}