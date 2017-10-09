using System;

public class Program {
  public static string Puzzle(string s) {
	  
	  string r = s.Substring(0,1);
	  
	  for(int count = s.Length-1; count > 0; ++count)
	  {
		  r+= s.Substring(count,1);
	  }
	  r += s.Substring(s.Length-1,1);
	  
    return r;
  }
}