using System;

public class Program {
  public static int Puzzle(string s) {
	  
	  string[] str = s.Split(' ');
	  int count = str.Length;
	  for (int i = 0; i < str.Length; i ++){
		  
		  if (String.ReferenceEquals(str[i], "")){
			  
			count--;
		  }
	  }
    return count; 
	
  }
}