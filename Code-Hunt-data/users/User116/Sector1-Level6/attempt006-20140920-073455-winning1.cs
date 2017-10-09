using System;

public class Program {
  public static int Puzzle(string s) {
	  int count = 0;
  	string[] split = s.Split(null);
	  foreach( string st in split)
	  {
		  if(st.Trim()!="")
		  count++;
	  }
	  return count;
  }
}