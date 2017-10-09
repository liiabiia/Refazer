using System;

public class Program {
  public static int Puzzle(string s) {
	  bool word = false;
	  int count = 0;
	  s = s.Trim(' ');
	  for(int i = 0; i< s.Length ; i++){
		  word = (Char.IsWhiteSpace(s[i]) == true) ? true : false;
		  if(word)count++;
	  }
	  return count;
  }
}