using System;

public class Program {
  public static string Puzzle(string s) {
	  var result = s;
	  for(int i=1; i<s.Length/2; i++){
		  result[i]=s[s.Length-i];
		  result[s.Length-i]=s[i];
	  }
    return result;
  }
}