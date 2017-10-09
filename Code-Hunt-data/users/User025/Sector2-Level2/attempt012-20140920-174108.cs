using System;

public class Program {
  public static int Puzzle(string s) {
	  int resultado = 0;
	  for(int i = 0; i < s.length; i++)
	  {
		  if(s.charAt(i) == '(')
		  	resultado++;
	  }
    return resultado;
  }
}