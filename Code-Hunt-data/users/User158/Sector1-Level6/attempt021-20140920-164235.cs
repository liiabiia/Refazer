using System;

public class Program {
  public static int Puzzle(string s) {
	  int index=1, count=0, count1=0;
    while (index < s.Length-1)
	{
		if((Char.IsWhiteSpace(s[index]) == true && Char.IsWhiteSpace(s[index+1]) == false && !(String.IsNullOrEmpty(s))) || (Char.IsWhiteSpace(s[index]) == true && Char.IsWhiteSpace(s[index-1]) == false ))
		{
		count++; count1++;
		}
       	index++;
	}
	if(count1!=0)
	count++;
	   return count;
}
}