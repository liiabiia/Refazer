using System;

public class Program {
  public static int Puzzle(string s) {
	  int x=0,y=0;
	  int[] art= new int[5];
	   int[] art2= new int[5];
	   if(s[0]=='(')
		  {
			  x++;
			  int l=0;
		while ((i = s.IndexOf('(', i)) != -1)
	{
		art[l]=i;
		
		l++;
	}
		  }
		  
	else	   if(s[0]==')')
		  {
			  y++;
				  int l=0;
		while ((i = s.IndexOf(')', i)) != -1)
	{
		art2[l]=i;
		
		l++;
	}
		  
		  }  
		
    return 0;
  }
}
