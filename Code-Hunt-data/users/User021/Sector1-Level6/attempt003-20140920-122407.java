

public class Program {
  public static int Puzzle(String s) {
	  int wordCount = 0;

    boolean word = false;
    int endOfLine = s.length() - 1;

    for (int i = 0; i < s.length(); i++) {
        if (!Character.isSpaceChar(s.charAt(i)) && i != endOfLine) {
            word = true;
        } else if (Character.isSpaceChar(s.charAt(i)) && word) {
            wordCount++;
            word = false;
        } else if (!Character.isSpaceChar(s.charAt(i)) && i == endOfLine) {
            wordCount++;
        }
    }
    return wordCount;
  }
}