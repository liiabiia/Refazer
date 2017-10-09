using System;

public class Program {
  public static int Puzzle(string s) {
    var words = s.Trim().Split(' ');
	int wordsCount = 0;
	foreach(string word in words)
	{
		if(!String.IsNullOrEmpty(word))
		{
			wordsCount++;
		}
	}
	return wordsCount;
  }
}