using System;

public class Program {
  public static int Puzzle(string s) {
	  int count = 1;
	  for(int i=0;i<s.Length;i++)
	  {
		  if(Char.IsWhiteSpace(s[i]) && Char.IsLetter(s[i+1]) || (Char.IsLetter(s[i]) && s[i-1]==null)
		  )
		  
			  ++count;
			  
			  
	
		 
		  
		  
	  }
    return count;
  }
}