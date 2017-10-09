using System;

public class Program {
  public static int Puzzle(string s) {
	  int i = 0;
	  string t = s.Replace("()","";
	  if(t.Contains("()"))
	  i+=1;
	  while(t.Contains("()"))
	  {
	  	i+=1;
	t = t.Replace("()","");		  
	  
	  }
	  return i;
  }
}