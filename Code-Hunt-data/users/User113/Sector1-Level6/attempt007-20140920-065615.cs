
using System;

public class Program {
  public static int Puzzle(string s) {
	  int count=0;
	  for(int i=0; i<s.Length;i++)
	  {
		  if(s[i]==" ")
		  { count++; }
	  }
    return count ;
  }
}