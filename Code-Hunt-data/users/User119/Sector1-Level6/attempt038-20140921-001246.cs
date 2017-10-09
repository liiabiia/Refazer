using System;

public class Program {
  public static int Puzzle(string s) {
	  
	  int count = 0;
	  int sentinela = false;
	  char[] str = s;
	  for (int i=0; i < str.Length; i ++){
		 
		 if(str[i] == ' ' && sentinela){
			 count +=1;
		 }
		  
	  }
    return str.Split(' ').Length; 
	
  }
}

