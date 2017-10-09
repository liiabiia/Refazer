using System;

public class Program {
  public static int Puzzle(string s) {
	  int counter=1;
		  if(!string.IsNullOrWhiteSpace(s)) {  
	  for(int i =0; i<s.Length-1; i++)
	  {
		  if(s[i] != ' ' && s[i+1]== ' ')
		  counter++; 
	  }
		  }
		  else 
		  counter =0;
    return counter;
  }
}