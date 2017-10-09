using System;

public class Program {
  public static int Puzzle(string s) {
	  int numwords = 0;
	  int index = 0;
	  bool preWhiteSpace = true;
	  while (index < s.length())
	  {
		  char c = s.charAt(index++);
		  bool whitespace = Character.isWhiteSpace(c);
	  }
	  
	  if(preWhiteSpace && whitespace)
	  {
		  numwords++;
	  }
	  
	  preWhiteSpace=whitespace;
  }
    return numwords;
  }
}