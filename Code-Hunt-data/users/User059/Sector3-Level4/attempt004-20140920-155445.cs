using System;

public class Program {
  public static bool Puzzle(char c) {
	  string x="gap";
	  for(int i=0;i<x.Length;i++)
	  {
		  if(c==x[i])
		  return true;
	  }
	 return true;
  }
}