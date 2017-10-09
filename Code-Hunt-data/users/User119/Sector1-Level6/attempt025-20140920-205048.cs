using System;

public class Program {
  public static int Puzzle(string s) {
	  
	  int count = 0;
	  string[] str = s.Split(' ')/;
	  for (int i = 0; i < str.Length; i ++){
		  
		  if (!String.ReferenceEquals(str[i], "")){
			  
			count += 1;
		  }
	  }
    return count; 
	
  }
}