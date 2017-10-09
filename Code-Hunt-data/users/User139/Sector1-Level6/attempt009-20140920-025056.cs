using System;

public class Program {
  public static int Puzzle(string s) {
	  int words = 0;
	  if(s[0] == ' ' && s[1] != ' ')
	  	words++;
    for(int i = 0; i < s.Length; i++){
			if(s[i] != ' ')
				continue;
			else
				words++;							
	}
	return words;
  }
}