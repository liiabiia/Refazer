using System;

public class Program {
  public static int Puzzle(string s) {
    int c =0;
	for(int i=0; i<=s.Length; i++){
if(char.IsWhiteSpace(s[i]) == true)
{
c++;
}
	}
return c;
  }
}