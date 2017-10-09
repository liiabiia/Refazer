using System;

public class Program {
  public static int Puzzle(string s) {
	  String word= s.Trim();
	  int count = 0, i = 0;
	  while (i < word.Length)
	  {
		  while (i < word.Length && Char.IsWhiteSpace(text[index]) == false)i++;
		  count++;
		  while (i < word.Length && Char.IsWhiteSpace(text[index]) == true)i++;
		}
		return count;
  }
}