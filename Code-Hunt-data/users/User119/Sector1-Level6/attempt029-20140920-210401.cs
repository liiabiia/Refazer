using System;

public class Program {
  public static int Puzzle(string s) {
	  
	  string[] str = s.Split(' ');
	  while(str.Contains("")){
		  str = str.Split(' ');
	  }
    return str.Length; 
	
  }
}