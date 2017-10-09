

public class Program {
  public static int Puzzle(String s) {
String words = getWordCount(s);
    return words.length();
}}

private static String  getWordCount(String s) {
    return s.split(" ");
}
 

  }
}