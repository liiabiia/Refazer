using System;

public class Program {
  public static int Puzzle(string s) {
	  int count =0;
	  for(int i=0;i<s.Length;i++)
	  {
		  if(s[i]==' ')
		  {
			  if(s[i+1]!=null || s[i+1]!=' ')
			  count++;
			  
			  
		  }
		  
		  
	  }
    return count;
  }
}