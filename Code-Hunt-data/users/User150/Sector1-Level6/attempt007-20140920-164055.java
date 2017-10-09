import java.lang.*;
public class Program {
  public static int Puzzle(String s) {
   int wordCount;
   int endOfLine = s.length() - 1;
   boolean word = false;
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