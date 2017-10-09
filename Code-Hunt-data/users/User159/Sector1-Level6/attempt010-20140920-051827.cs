using System;

public class Program {
  public static int Puzzle(string s) {
	  int count=1;
	  for(int i=0; i<=s.Length; i++)
	  {
		  if(char.IsWhiteSpace(s[i-1]) == true)
		  return count++;
	  }
    return count;
  }
}