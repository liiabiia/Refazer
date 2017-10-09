using System;

public class Program {
  public static int Puzzle(string s) {
	  int count = 0,x;
	  for ( x >= 0 ; x <= s ; x++ )
	  {
		  if ((s[x]==' ')&&(s[0]!=' '))
		  {
			  count++;
		  }
	  }
    return count;
  }
}