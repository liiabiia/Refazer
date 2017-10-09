using System;

public class Program {
  public static string Puzzle(string s) {
	  char[] inputarray = s.ToCharArray();
Array.Reverse(inputarray);
inputarray[0]=s[0];
inputarray[s.Length-1]= s[s.Length-1];

    return new string(inputarray);
  }
}