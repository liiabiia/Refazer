using System;

public class Program {
  public static int Puzzle(string s) {
	  char c;
	  int j;
	  for(i=0;i<sizeof(s);i++)
	  {
		  c=s[i];
		  if(c=="")
		  j++;		  
	  }
    return j;
  }
}