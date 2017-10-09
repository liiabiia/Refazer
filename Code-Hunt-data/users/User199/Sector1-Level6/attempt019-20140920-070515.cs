using System;

public class Program {
  public static int Puzzle(string s) {
	  int counter=0;
	  foreach(char c in s)
	  {
		  if(char.IsLetter(c))
		  {
			  counter++;
		  }
	  }
    return counter;
  }
}