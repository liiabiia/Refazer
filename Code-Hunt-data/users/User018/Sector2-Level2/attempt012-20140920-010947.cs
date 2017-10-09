using System;

public class Program {
  public static int Puzzle(string s) {
	  int i = 0;
	  string t = s.Replace("()","");
	  while(t.Contains("()"))
	  {
	  	i+=1;
	t = s.Replace("()","");		  
	  
	  }
	  return i;
  }
}