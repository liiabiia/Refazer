using System;

public class Program {
  public static int Puzzle(string s) {
	  int i = 0;
	  string t = s.Replace("a","");

	  while(t.Contains("()"))
	  {
	  	i+=1;
	t = t.Replace("()","");		  
	  
	  
	  }
	  if(t.Contains("(")||t.Contains(")"))
	  return 0;
	  return i;
  }
}