using System;

public class Program {
  public static int Puzzle(string s) {
	  int index=0, count=1;
    while (index < s.Length)
	{
		if(Char.IsWhiteSpace(s[index]) == true && Char.IsWhiteSpace(s[index+1]) == false)
		count++;
       	index++;
	}
	   return count++;
}
}