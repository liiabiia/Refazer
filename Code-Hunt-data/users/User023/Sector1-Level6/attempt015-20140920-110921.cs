using System;

public class Program {
  public static int Puzzle(string s) {
	  int wordCount = 0, index = 0;
	  string text=s;

while (index < text.Length)
{
   // check if current char is part of a word
   while (index < text.Length && Char.IsWhiteSpace(text[index]) == false)
       index++;

   wordCount++;

   // skip whitespace until next word
   while (index < text.Length && Char.IsWhiteSpace(text[index]) == true)
       index++;
}
    return wordCount;
  }
}