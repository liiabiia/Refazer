using System;

public class Program {
  public static int Puzzle(string s) {
	  
	  string str = s;
	  while(str.Contains("  ")){
		  str = str.Replace("  ", " ");
	  }
    return str.Split(' ').Length; 
	
  }
}