

public class Program {
  public static int Puzzle(String s) {
    int count = getWordCount();
    while (int i = 0; i < s.length(); i++)
    {
        if (s.charAt(i) == " ")
        {
            count ++;
        }
    }
    getWordCount(count); 
  }
}