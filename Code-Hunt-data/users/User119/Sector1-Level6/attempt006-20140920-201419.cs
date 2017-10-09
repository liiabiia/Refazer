using System;

public class Program {
  public static int Puzzle(string s) {
	  
	  int count = 0;
	  
	  for (int i = 0; i < s.Split(' ').Length; i ++){
		  
		  if (!(String.Compare(s.Split(' ')[i], " ", true))){
			  
			count += 1;
		  }
	  }
    return count; 
	
  }
}