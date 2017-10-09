using System;

public class Program {
  public static int Puzzle(string s) {
	  
	  string str = s.Replace('  ');
	  while(str.Contains("  ")){
		  str = str.Replace('  ');
	  }
    return str.Length; 
	
  }
}