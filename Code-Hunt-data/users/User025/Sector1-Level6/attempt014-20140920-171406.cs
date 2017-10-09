using System;

public class Program {
  public static int Puzzle(string s) {
	  int sl = s.length();
	  int resultado = 0;
	    for(int i = 1; i < sl; i++){
			if(s.charAt(i) != ' ' && s.charAt(i-1) == ' '){
				resultado++;
				i++;
			}
		}
	return resultado;
  }
}