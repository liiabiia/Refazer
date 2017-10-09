using System;

public class Program {
  public static int Puzzle(string s) {
	  int copen = 0;
	  int cclose = 0;
	  
	  for(int count = 0; count < s.Length;++count)
	  {
		  if(s.Substring(count,1).Equals("("))
		  {
			  ++copen;
		  }
		  else if(s.Substring(count,1).Equals(")"))
		  {
			  ++cclose;
		  }
	  }
	  
	  if( copen == cclose) copen=(copen+cclose)/2;
	  else copen=cclose =0;
	  
    return copen;
  }
}