using System;

public class Program {
  public static int Puzzle(string s) {
	  int wordCount = 0;

    bool word = false;
    int endOfLine = s.length() - 1;

    for (int i = 0; i < s.length(); i++) {
          if (Character.isLetter(s.charAt(i)) && i != endOfLine) {
            word = true;
        } else if (!Character.isLetter(s.charAt(i)) && word) {
            wordCount++;
            word = false;
        } else if (Character.isLetter(s.charAt(i)) && i == endOfLine) {
            wordCount++;
        }
    }
    return wordCount;
    
  }
}