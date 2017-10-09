using System;
using System.Linq;

public class Program {
	
  public static int Puzzle(string s) {
	  string lastChar, actualChar;
	  int count = 0;
	  for (int i = 0; i <= s.Count(); i++)
	  {
		  actualChar = s[i].ToString();
		  
		  if ( !lastChar.IsNullOrEmpty  (lastChar == actualChar))
		  {
			  
		  }
	  }
	  
	  return count / 4;
  }
}