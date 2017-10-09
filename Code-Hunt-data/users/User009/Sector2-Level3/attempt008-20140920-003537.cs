using System;

public class Program {
  public static string Puzzle(string s) {
	  var result = s[0].ToString();
	  for(int i=1; i<s.Length-1; i++){
		  result+=s[s.Length-i-1];
	  }
	  result += s[s.Length];
    return result;
  }
}