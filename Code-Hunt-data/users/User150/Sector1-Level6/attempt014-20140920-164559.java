import java.lang.*;
public class Program {
  public static int Puzzle(String s) {
   int wordCount=0;
   int endOfLine = s.length() - 1;
   boolean word = false;
   for (int i = 0; i < s.length(); i++) {
        if (Character.isLetter(s.charAt(i)) && i != endOfLine) {
            word = true;
            } 
    }
    return wordCount;
  }
}