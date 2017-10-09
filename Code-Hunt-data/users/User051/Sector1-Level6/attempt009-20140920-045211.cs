using System;

public class Program {
  public static int Puzzle(string s) {
	  int sum = 0;
	  for(int i = 0;i<s.Length;i++)
	  {
		  if(s[i] != ' '){
			  sum++;
			  while(s[i]!=' '||i<s.Length)
			  i++;
		  }
	  }
    return sum;
  }
}