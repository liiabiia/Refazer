using System;

public class Program {
  public static int Puzzle(string s) {
	  int index=0;
    while (index < s.Length)
	{
		if(Char.IsWhiteSpace(s[index]) == true)
       	index++;
	}
	   return index++;
}
}