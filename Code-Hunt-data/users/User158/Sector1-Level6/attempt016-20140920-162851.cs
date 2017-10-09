using System;

public class Program {
  public static int Puzzle(string s) {
	  int index=1, count=1;
    while (index < s.Length-1)
	{
		if(Char.IsWhiteSpace(s[index]) == true && Char.IsWhiteSpace(s[index+1]) == false)
		count++;
       	index++;
	}
	   return count;
}
}