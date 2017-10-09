using System;

public class Program {
  public static int Puzzle(string s) {
	  
	  int cw = 0;
	  bool inword = false;
	  for(int count = 0; count < s.Length; ++count)
	  {
		  if(s.Substring(count,1).Equals(" ") && !inword)
		  {
			  inword = true;
		  }
		  else ++cw;
	  }
    return cw;
  }
}