using System;

public class Program {
  public static int Puzzle(string s) {
	  int count = 0;
  	string[] split = s.Split(null);
	  foreach( string s in split)
	  {
		  if(s.Trim()!="")
		  count++;
	  }
	  return count;
  }
}