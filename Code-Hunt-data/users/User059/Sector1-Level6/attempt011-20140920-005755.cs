using System;

public class Program {
  public static int Puzzle(string s) {
	
	int wordCount = 0, index = 0;

while (index < text.Length)
{
 
   while (index < text.Length && Char.IsWhiteSpace(text[index]) == false)
       index++;

   wordCount++;

   
   while (index < text.Length && Char.IsWhiteSpace(text[index]) == true)
       index++;
}
return wordCount;
  }
}