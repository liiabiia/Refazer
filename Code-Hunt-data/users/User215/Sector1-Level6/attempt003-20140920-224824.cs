using System;

public class Program {
  public static int Puzzle(string s) {
	  int count = 0;
	  for (int x >= = ; x <= s.Length ; x++ )
	  {
		  if ((s[x]==' ')&&(s[0]!=' '))
		  {
			  count++;
		  }
	  }
    return count;
  }
}