

public class Program {
  public static int Puzzle(String s) {
    int count = 1;


        for (int i=0;i<=s.length()-1;i++)
        {
            if (s.charAt(i) == ' ' && s.charAt(i+1)!=' ')
            {
                count++;
            }
        }
        return count;

  }
}