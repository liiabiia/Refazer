using System;

public class Program {
  public static string Puzzle(string s) {
	char temp; char[] ret = s.ToCharArray();
    for(int i=1; i<s.Length/2-1; i++) {
		temp = ret[i];
		ret[i] = ret[s.Length-i-1];
		ret[s.Length-i-1] = temp;
	  }
	  return new string(ret);
  }
}