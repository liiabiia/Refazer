using System;

public class Program {
  public static string Puzzle(string s) {
	  var result = s[0];
	  for(int i=1; i<s.Length-1; i++){
		  result[i]+=s[s.Length-i];
	  }
	  result += s[s.Length];
    return result;
  }
}