using System;

public class Program {
  public static int Puzzle(string s) {
	
	int wordCount = 0, index = 0;

while (index < s.Length)
{
	 while (index < s.Length && Char.IsWhiteSpace(s[index]) == true)
  
       ++index;
 
   while (index < s.Length && Char.IsWhiteSpace(s[index]) == false)
       ++index;
++ wordCount;
 
  
   
  
	   
	     
  
}
return wordCount;
  }
}