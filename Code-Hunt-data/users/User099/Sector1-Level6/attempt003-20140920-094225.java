

public class Program {
  public static int Puzzle(String s) {
     int count = 1;
	 if(s.charAt(0) == ' ') count = 0;
        for (int i=0;i<=str.length()-1;i++)
        {
            if (str.charAt(i) == ' ' && str.charAt(i+1)!=' ')
            {
                count++;
            }
        }
        return count;
  }
}