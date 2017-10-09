

public class Program {
  public static int Puzzle(String s) {
String words = getWordCount(s);
    return words.length();
}}

private static int getWordCount(String s) {
    return s.split(" ");
}
 

  }
}